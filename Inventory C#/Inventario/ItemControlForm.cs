using Inventario.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public class LoadingForm : Form
    {
        private Label loadingLabel;

        public LoadingForm(string loadingText)
        {
            Text = "Cargando...";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            ShowInTaskbar = false;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Size = new Size(200, 100);

            loadingLabel = new Label();
            loadingLabel.Text = loadingText;
            loadingLabel.AutoSize = false;
            loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            loadingLabel.Dock = DockStyle.Fill;
            Controls.Add(loadingLabel);
        }
    }

    public partial class ItemControlForm : Form
    {
        public int currentRow;
        private Thread loadingThread;
        private LoadingForm loadingForm;

        public ItemControlForm()
        {
            InitializeComponent();
        }

        private void ItemControlForm_Load(object sender, EventArgs e)
        {
            loadingForm = new LoadingForm("Cargando datos de productos.");
            loadingThread = new Thread(ShowLoadingForm);
            loadingThread.Start();
                
            dataView.DataSource = Inventory.ItemsList;
            dataView.CellFormatting += dataView_CellFormatting;
            dataView.ClearSelection();

            loadingForm.Invoke(new Action(() => loadingForm.Close()));
            loadingThread.Join();
        }

        private void ShowLoadingForm()
        {
            Application.Run(loadingForm);
        }

        private void dataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dataView.Columns["Price"].Index || e.ColumnIndex == dataView.Columns["SellPrice"].Index) && e.Value != null)
            {
                float price = (float)e.Value;
                e.Value = $"${price.ToString("0.00")}";
                e.FormattingApplied = true;
            }
        }
  
        private BindingList<Item> itemsList;  // Lista de objetos Item
        private int currentItemIndex;  // Índice del elemento actual en la lista
        private int totalPages;        // Número total de páginas
        private int currentPage;       // Número de página actual

        public void PrintCurrentData()
        {
            totalPages = 0;
            currentPage = 0;
            currentItemIndex = 0;
            itemsList = Inventory.ItemsList;
            ConfigurePrinting();
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
                graphics.DrawString("Fecha: " + fecha, font, Brushes.Black, startX, currentY);
                currentY += lineHeight;
                graphics.DrawString("Nombre: " + nombre, font, Brushes.Black, startX, currentY);
                currentY += lineHeight * 2;
            }

            // Imprimir cabecera de la tabla
            string[] cabecera = { "ID", "Nombre", "Precio", "Precio Venta", "Proveedor", "Fabricante", "Stock" };
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
                    pageInfo = currentPage + " de " + (currentPage == 1 ? totalPages-1 : totalPages);
                    pageX = e.PageBounds.Right - graphics.MeasureString(pageInfo, font).Width;
                    pageY = e.PageBounds.Bottom - lineHeight;
                    graphics.DrawString(pageInfo, font, Brushes.Black, pageX-20, pageY-20);
                    return;
                }

                Item item = itemsList[currentItemIndex];
                float filaY = currentY;

                graphics.DrawRectangle(Pens.Black, tablaX, filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.ID, font, Brushes.Black, tablaX, filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + celdaAncho, filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Name.Substring(0, Math.Min(item.Name.Length, 15)), font, Brushes.Black, tablaX + celdaAncho, filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (2 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Price.ToString(), font, Brushes.Black, tablaX + (2 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (3 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.SellPrice.ToString(), font, Brushes.Black, tablaX + (3 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (4 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Provider, font, Brushes.Black, tablaX + (4 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (5 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.Manufacturer, font, Brushes.Black, tablaX + (5 * celdaAncho), filaY);

                graphics.DrawRectangle(Pens.Black, tablaX + (6 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(item.inStockCount.ToString(), font, Brushes.Black, tablaX + (6 * celdaAncho), filaY);

                currentItemIndex++;
                currentY += celdaAlto;
            }

            // Imprimir número de página
            pageInfo = (currentPage+1) + " de " + totalPages;
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


        public void UpdateItem(Item myItem, int row)
        {
            if (myItem != null)
            {
                //MessageBox.Show($"RECIVE CALLBACK: UPDATE!");
                Inventory.ItemsList[row] = myItem;
                currentRow = row;
                Inventory.SaveDataBase();
            }
            ReEnable();

        }

        public void NewItem(Item toAdd, int row)
        {
            if (toAdd != null)
            {
                // MessageBox.Show($"RECIVE CALLBACK: NEW! {toAdd.Name}");
                Inventory.ItemsList.Add(toAdd);
                currentRow = Inventory.ItemsList.IndexOf(toAdd);
                Inventory.SaveDataBase();
            }
            ReEnable();
        }

        void Disable()
        {
            PrincipalPanel.Enabled = false;

        }

        void ReEnable()
        {
            dataView.Refresh();
            PrincipalPanel.Enabled = true;
            if (currentRow != -1)
            {
                SetItemPreview(Inventory.ItemsList[currentRow]);
                dataView.Rows[currentRow].Selected = true;
            }
            else
            {
                dataView.ClearSelection();
                itemPicture.Image = Resources.missingImage;
            }
        }

        private void BT_print_Click(object sender, EventArgs e)
        {
            PrintCurrentData();
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;

            if (row != -1)
            {
                Disable();
                EditWindow itemEdit = new EditWindow();
                itemEdit.SetData(Inventory.ItemsList[row], row);

                TaskCompletedCallBack callback = UpdateItem;
                itemEdit.SetCallback(callback);
                itemEdit.TopMost = true;
                itemEdit.Show();
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
            if(currentRow != -1)
                SetItemPreview(Inventory.ItemsList[currentRow]);
        }

        private void BT_NewItem_Click(object sender, EventArgs e)
        {
            EditWindow itemEdit = new EditWindow();

            TaskCompletedCallBack callback = NewItem;
            itemEdit.SetCallback(callback);
            itemEdit.TopMost = true;
            itemEdit.Show();
            Disable();
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            if (currentRow != -1)
            {
                
                EditWindow itemEdit = new EditWindow();
                itemEdit.SetData(Inventory.ItemsList[currentRow], currentRow);

                TaskCompletedCallBack callback = UpdateItem;
                itemEdit.SetCallback(callback);
                itemEdit.TopMost = true;
                itemEdit.Show();
                Disable();
            }
        }

        private void BT_DeleteItem_Click(object sender, EventArgs e)
        {
            if (currentRow != -1)
            {
                Disable();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Confirmar eliminación.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.ItemsList.RemoveAt(currentRow);
                    currentRow = -1;
                    itemPicture.Image = Resources.missingImage;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

                ReEnable();


            }
        }

        public void SetItemPreview(Item currentItem)
        {
            Inventory.ClearTemp();
            if (currentItem.IconPath != null)
            {
                if (File.Exists(currentItem.IconPath))
                {
                    if (!Directory.Exists(Path.Combine(Path.GetTempPath(), "ElciInventory")))
                    {
                        Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), "ElciInventory"));
                    }
                    string tempImagePath = Path.Combine(Path.GetTempPath(), "ElciInventory", Guid.NewGuid().ToString());
                    File.Copy(currentItem.IconPath, tempImagePath, true);
                    itemPicture.Image = Image.FromFile(tempImagePath);
                }
                else
                    itemPicture.Image = Resources.missingImage;
            }
            else
                itemPicture.Image = Resources.missingImage;
            nameLabel.Text = currentItem.Name;
            codeLabel.Text = currentItem.ID;
            priceLabel.Text = $"${currentItem.Price}";
            sellPriceLabel.Text = $"${currentItem.SellPrice}";
            manuLabel.Text = $"{currentItem.Manufacturer}";
            provLabel.Text = currentItem.Provider;
            DescTextBox.Text = currentItem.Description;
            stockLabel.Text = currentItem.inStockCount.ToString();
        }
    }
}
