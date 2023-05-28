using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class BillingForm : Form
    {
        List<string> EntriesList = new List<string>();
        List<string> ExitsList = new List<string>();
        List<string> CheckList = new List<string>();
        Options currentOption = Options.Entries;
        public int currentItem = -1;

        public string printRegistryName = "";
        public string printRegistryDate = "";
        public string printRegistryTotal = "";

        public ExitData dataExit;
        enum Options
        {
            Entries = 0,
            Exits = 1
        }
        public BillingForm()
        {
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            foreach (EntryData entry in Inventory.EntriesData)
            {
                var entrieData = $"[{entry.Id}] | {entry.Name} | {entry.date}";
                EntriesList.Add(entrieData);
            }

            foreach (ExitData entry in Inventory.ExitsData)
            {
                var exitData = $"[{entry.Id}] | {entry.Name} | {entry.date}";
                ExitsList.Add(exitData);
            }


            dataView.Columns.Add("Code", "ID");
            dataView.Columns.Add("Name", "Nombre");
            dataView.Columns.Add("Price", "Precio");
            dataView.Columns.Add("SellPrice", "Precio de venta");
            dataView.Columns.Add("Count", "Cantidad");
            dataView.Columns.Add("Total", "Total");

            dataView.CellFormatting += dataView_CellFormatting;
            UpdateDropDown();

        }

        private void dataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dataView.Columns["Price"].Index || e.ColumnIndex == dataView.Columns["SellPrice"].Index || e.ColumnIndex == dataView.Columns["Total"].Index) && e.Value != null)
            {
                float price = (float)e.Value;
                e.Value = $"${price.ToString("0.00")}";
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                e.FormattingApplied = true;
            }
        }
        private BindingList<Item> itemsList = null;
        private BindingList<float> SubtotalList = new BindingList<float>();// Lista de objetos Item
        private BindingList<int> CountList = new BindingList<int>();
        private int currentItemIndex;  // Índice del elemento actual en la lista
        private int totalPages;        // Número total de páginas
        private int currentPage;       // Número de página actual

        private void PrintCurrentData()
        {
            if (itemsList != null)
            {
                totalPages = 0;
                currentPage = 0;
                currentItemIndex = 0;
                ConfigurePrinting();
            }
            else
                MessageBox.Show("Seleccione un registro");
        }

        private void FacturaPrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight();

            // Obtener los datos de la factura
            string fecha = "08 de mayo de 2023";
            string nombre = "Juan Pérez";

            float startX = 70;
            float startY = 100;
            float currentY = startY;

            // Imprimir encabezado solo en la primera página
            if (currentPage == 0)
            {
                graphics.DrawString("Fecha del registro: " + printRegistryDate, font, Brushes.Black, startX, currentY);
                currentY += lineHeight;
                graphics.DrawString("Nombre del registro: " + printRegistryName, font, Brushes.Black, startX, currentY);

                if (currentOption == Options.Exits)
                {
                    if (dataExit != null)
                    {
                        currentY += lineHeight;
                        graphics.DrawString("Nombre del cliente: " + dataExit.clientName, font, Brushes.Black, startX, currentY);
                        currentY += lineHeight;
                        graphics.DrawString("Domicilio fiscal: " + dataExit.clientAddress, font, Brushes.Black, startX, currentY);
                        currentY += lineHeight;
                        graphics.DrawString("RIF o C.I.N° del cliente: " + dataExit.clientDNI, font, Brushes.Black, startX, currentY);
                    }
                }
                currentY += lineHeight * 2;
            }

            // Imprimir cabecera de la tabla
            string[] cabecera = { "ID", "Nombre", "Precio", "Cantidad", "Proveedor", "Fabricante", "Subtotal" };
            float tablaX = startX;
            float tablaY = currentY;
            float celdaAncho = 100;
            float celdaAlto = lineHeight + 4;

            for (int i = 0; i < cabecera.Length; i++)
            {
                float celdaX = tablaX + (i * celdaAncho);
                graphics.DrawRectangle(Pens.Black, celdaX, tablaY, celdaAncho, celdaAlto);
                graphics.DrawString(cabecera[i], font, Brushes.Black, celdaX, tablaY);
            }

            currentY += celdaAlto;

            // Calcular número total de páginas
            int itemsPerPage = (int)((e.MarginBounds.Height - currentY) / celdaAlto);
            totalPages = (int)Math.Ceiling((double)itemsList.Count / itemsPerPage);


            string pageInfo = (currentPage + 1) + " de " + totalPages;
            float pageX = e.PageBounds.Right - graphics.MeasureString(pageInfo, font).Width;
            float pageY = e.PageBounds.Bottom - lineHeight;

            // Imprimir datos de la tabla
            while (currentItemIndex < itemsList.Count)
            {
                // Verificar si es necesario crear una nueva página
                if (currentY + celdaAlto > e.MarginBounds.Bottom)
                {
                    currentPage++;
                    e.HasMorePages = true;
                    pageInfo = currentPage + " de " + totalPages;
                    pageX = e.PageBounds.Right - graphics.MeasureString(pageInfo, font).Width;
                    pageY = e.PageBounds.Bottom - lineHeight;
                    graphics.DrawString(pageInfo, font, Brushes.Black, pageX - 20, pageY - 20);
                    return;
                }

                Item item = itemsList[currentItemIndex];
                float filaY = currentY;

                graphics.DrawRectangle(Pens.Black, tablaX, filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.ID, font, Brushes.Black, tablaX, filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + celdaAncho, filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Name.Substring(0, Math.Min(item.Name.Length, 15)), font, Brushes.Black, tablaX + celdaAncho, filaY);


                float priceToPrint = currentOption == Options.Entries ? item.Price : item.SellPrice;

                graphics.DrawRectangle(Pens.Black, tablaX + (2 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString("$ " + String.Format("{0:0.00}", priceToPrint), font, Brushes.Black, tablaX + (2 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (3 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(CountList[currentItemIndex].ToString(), font, Brushes.Black, tablaX + (3 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (4 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Provider, font, Brushes.Black, tablaX + (4 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (5 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Manufacturer, font, Brushes.Black, tablaX + (5 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (6 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString("$ " + String.Format("{0:0.00}", SubtotalList[currentItemIndex]), font, Brushes.Black, tablaX + (6 * celdaAncho), filaY);

                currentItemIndex++;
                currentY += celdaAlto;
            }

            graphics.DrawString(printRegistryTotal, font, Brushes.Black, tablaX + (6 * celdaAncho), currentY);
            graphics.DrawRectangle(Pens.Black, tablaX + (6 * celdaAncho), currentY, celdaAncho, celdaAlto);

            // Imprimir número de página
            pageInfo = (currentPage + 1) + " de " + totalPages;
            pageX = e.PageBounds.Right - graphics.MeasureString(pageInfo, font).Width;
            pageY = e.PageBounds.Bottom - lineHeight;
            graphics.DrawString(pageInfo, font, Brushes.Black, pageX - 20, pageY - 20);

            // Verificar si hay más páginas para imprimir

            e.HasMorePages = false;

        }

        // Método para configurar la impresión
        public void ConfigurePrinting()
        {
            PrintDocument facturaPrintDocument = new PrintDocument();
            facturaPrintDocument.PrintPage += new PrintPageEventHandler(FacturaPrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = facturaPrintDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Mostrar vista previa de impresión
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                facturaPrintDocument.PrinterSettings = printDialog.PrinterSettings;
                printPreviewDialog.Document = facturaPrintDocument;
                printPreviewDialog.ShowDialog();
            }
        }


        public void UpdateDropDown()
        {
            string searchText = FilterBox.Text.ToLower();
            
            CheckList = currentOption == Options.Entries ? EntriesList : ExitsList;
            itemsList = null;
            dataView.Rows.Clear();
            currentItem = -1;
            printRegistryName = "";
            printRegistryDate = "";
            dataNameLabel.Text = "";
            registerDate.Text = "";
            clienNameLabel.Text = "";
            clientAddressLabel.Text = "";
            ClientDNILabel.Text = "";

            if (currentOption == Options.Entries)
            {
                PanelClientData.Visible = false;
            }
            else
                PanelClientData.Visible = true;
                dropDown.Items.Clear();

            // Filtra los elementos de acuerdo con el texto ingresado por el usuario
            foreach (string item in CheckList)
            {
                if (item.ToLower().Contains(searchText))
                {
                    dropDown.Items.Add(item);
                }
            }
            
        }

        public void SetData(int index)
        {
            if(currentOption == Options.Entries)
            {
                EntryData data = Inventory.EntriesData[index];
                if (itemsList != null)
                    itemsList.Clear();
                else
                    itemsList = new BindingList<Item>();
                printRegistryName = data.Name;
                printRegistryDate = data.date.ToString();
                dataNameLabel.Text = data.Name;
                dataExit = null;
                registerDate.Text = data.date.ToString();
                dataView.Rows.Clear();
                SubtotalList.Clear();
                CountList.Clear();
                if (data.Items != null)
                {
                    float Total = 0;
                    foreach (EntryItem item in data.Items)
                    {
                        var newItem = dataView.Rows.Add();
                        foreach (Item myitem in Inventory.ItemsList)
                        {
                            if (myitem.ID == item.ItemID)
                            {
                                itemsList.Add(myitem);
                                dataView.Rows[newItem].Cells[0].Value = myitem.ID;
                                dataView.Rows[newItem].Cells[1].Value = myitem.Name;
                                dataView.Rows[newItem].Cells[2].Value = myitem.Price;
                                dataView.Rows[newItem].Cells[3].Value = myitem.SellPrice;
                                dataView.Rows[newItem].Cells[4].Value = item.Count;
                                dataView.Rows[newItem].Cells[5].Value = myitem.Price * item.Count;
                                SubtotalList.Add(myitem.Price * item.Count);
                                CountList.Add(item.Count);
                                Total += myitem.Price * item.Count;
                            }
                        }
                    }

                    TotalLabel.Text = "$ " + String.Format("{0:0.00}", Total);
                    printRegistryTotal = TotalLabel.Text;
                }
            }
            else
            {
                ExitData data = Inventory.ExitsData[index];

                dataExit = data;
                if (itemsList != null)
                    itemsList.Clear();
                else
                    itemsList = new BindingList<Item>();
                printRegistryName = data.Name;
                printRegistryDate = data.date.ToString();
                dataNameLabel.Text = data.Name;
                registerDate.Text = data.date.ToString();
                clienNameLabel.Text = data.clientName;
                clientAddressLabel.Text = data.clientAddress;
                ClientDNILabel.Text = data.clientDNI;
                dataView.Rows.Clear();
                SubtotalList.Clear();
                CountList.Clear();
                if (data.Items != null)
                {
                    float Total = 0;
                    foreach (ExitItem item in data.Items)
                    {
                        var newItem = dataView.Rows.Add();
                        foreach (Item myitem in Inventory.ItemsList)
                        {
                            if (myitem.ID == item.ItemID)
                            {
                                itemsList.Add(myitem);
                                dataView.Rows[newItem].Cells[0].Value = myitem.ID;
                                dataView.Rows[newItem].Cells[1].Value = myitem.Name;
                                dataView.Rows[newItem].Cells[2].Value = myitem.Price;
                                dataView.Rows[newItem].Cells[3].Value = myitem.SellPrice;
                                dataView.Rows[newItem].Cells[4].Value = item.Count;
                                dataView.Rows[newItem].Cells[5].Value = myitem.SellPrice * item.Count;
                                SubtotalList.Add(myitem.SellPrice * item.Count);
                                CountList.Add(item.Count);
                                Total += myitem.SellPrice * item.Count;
                            }
                        }
                    }
                    TotalLabel.Text = "$ " + String.Format("{0:0.00}", Total);
                    printRegistryTotal = TotalLabel.Text;
                }
            }
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string check in CheckList)
            {
                if (check == dropDown.Text)
                {
                    var index = CheckList.IndexOf(check);
                    SetData(index);
                    currentItem = index;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BT_selectEntries_Click(object sender, EventArgs e)
        {
            currentOption = Options.Entries;
            UpdateDropDown();
        }

        private void BT_selectExits_Click(object sender, EventArgs e)
        {
            currentOption = Options.Exits;
            UpdateDropDown();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_Print_Click(object sender, EventArgs e)
        {
            PrintCurrentData();
        }
    }
}
