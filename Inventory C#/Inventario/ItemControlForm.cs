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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ItemControlForm : Form
    {
        public int currentRow;
        public ItemControlForm()
        {
            InitializeComponent();
        }

        private void ItemControlForm_Load(object sender, EventArgs e)
        {
            
            dataView.DataSource = Inventory.ItemsList;
            dataView.CellFormatting += dataView_CellFormatting;
            dataView.ClearSelection();
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

        public void PrintCurrentData()
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

        private void FacturaPrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);

            // Aquí puedes dibujar la factura en el objeto Graphics

            // Ejemplo: Dibujar texto
            string fecha = "08 de mayo de 2023";
            string nombre = "Juan Pérez";

            graphics.DrawString("Fecha: " + fecha, font, Brushes.Black, new PointF(100, 100));
            graphics.DrawString("Nombre: " + nombre, font, Brushes.Black, new PointF(100, 120));

            float tablaX = 100;
            float tablaY = 200;
            float celdaAncho = 110;
            float celdaAlto = 20;

            // Dibujar cabecera de la tabla
            string[] cabecera = { "ID", "Nombre", "Precio", "Precio Venta", "Proveedor", "Fabricante" };

            for (int i = 0; i < cabecera.Length; i++)
            {
                float celdaX = (tablaX + (i * celdaAncho));
                graphics.DrawRectangle(Pens.Black, celdaX, tablaY, celdaAncho, celdaAlto);
                graphics.DrawString(cabecera[i], new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(celdaX, tablaY));
            }

            var ItemsList = Inventory.ItemsList;

            // Dibujar datos de la tabla
            for (int i = 0; i < ItemsList.Count; i++)
            {
                float filaY = (tablaY + ((i + 1) * celdaAlto));

                graphics.DrawRectangle(Pens.Black, tablaX, filaY, celdaAncho, celdaAlto);
                graphics.DrawString(ItemsList[i].ID, font, Brushes.Black, new PointF(tablaX, filaY));

                graphics.DrawRectangle(Pens.Black, tablaX + celdaAncho, filaY, celdaAncho, celdaAlto);
                graphics.DrawString(ItemsList[i].Name, font, Brushes.Black, new PointF(tablaX + celdaAncho, filaY));

                graphics.DrawRectangle(Pens.Black, tablaX + (2 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(ItemsList[i].Price.ToString(), font, Brushes.Black, new PointF(tablaX + (2 * celdaAncho), filaY));

                graphics.DrawRectangle(Pens.Black, tablaX + (3 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(ItemsList[i].SellPrice.ToString(), font, Brushes.Black, new PointF(tablaX + (3 * celdaAncho), filaY));

                graphics.DrawRectangle(Pens.Black, tablaX + (4 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(ItemsList[i].Provider, font, Brushes.Black, new PointF(tablaX + (4 * celdaAncho), filaY));

                graphics.DrawRectangle(Pens.Black, tablaX + (5 * celdaAncho), filaY, celdaAncho, celdaAlto);
                graphics.DrawString(ItemsList[i].Manufacturer, font, Brushes.Black, new PointF(tablaX + (5 * celdaAncho), filaY));
            }
        }

        public void UpdateItem(Item myItem, int row)
        {
            //MessageBox.Show($"RECIVE CALLBACK: UPDATE!");
            Inventory.ItemsList[row] = myItem;
            currentRow = row;
            dataView.Refresh();
            ReEnable();

        }

        public void NewItem(Item toAdd, int row)
        {
            // MessageBox.Show($"RECIVE CALLBACK: NEW! {toAdd.Name}");
            Inventory.ItemsList.Add(toAdd);
            currentRow = Inventory.ItemsList.IndexOf(toAdd);
            ReEnable();
        }

        void Disable()
        {
            PrincipalPanel.Enabled = false;

        }

        void ReEnable()
        {
            dataView.Refresh();
            
            Inventory.SaveDataBase();
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
                EditWindow itemEdit = new EditWindow();
                itemEdit.SetData(Inventory.ItemsList[row], row);

                TaskCompletedCallBack callback = UpdateItem;
                itemEdit.SetCallback(callback);

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
            }
            else
                itemPicture.Image = Resources.missingImage;
        }
    }
}
