using Inventario.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Inventario
{
    public partial class Form1 : Form
    {

        public List<Item> ItemsList = new List<Item>();
        PrintDocument facturaPrintDocument;
        public Form1()
        {
            InitializeComponent();
            ItemsList = TestList();

            dataView.DataSource = ItemsList;

        }

        public List<Item> TestList()
        {
            var retList = new List<Item>();
            retList.Add(new Item()
            {
                ID = "",
                Name = "Dorilocos",
                Manufacturer = "Navis",
                Provider = "rascct",
                Description = "adsdda",
                Price = 1.5f,
                SellPrice = 1.75f
            });

            retList.Add(new Item()
            {
                ID = "",
                Name = "Pesi",
                Manufacturer = "Resvis",
                Provider = "Yascct",
                Description = "qwerts",
                Price = 0.5f,
                SellPrice = 0.75f
            });

            return retList;
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
            MessageBox.Show($"RECIVE CALLBACK: UPDATE!");
            ItemsList[row] = myItem;


            dataView.Update();
        }

        public void NewItem(Item toAdd, int row)
        {
            MessageBox.Show($"RECIVE CALLBACK: NEW! {toAdd.Name}");
            ItemsList.Add(toAdd);
            dataView.DataSource = ItemsList;
            var msg = "";
            foreach(Item item in ItemsList)
            {
                msg += item.Name + "\n";
            }
            MessageBox.Show($"ProductList :\n {msg}");
            dataView.Update();
        }



        private void printPreviewDialog_PrintClick(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = facturaPrintDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                facturaPrintDocument.Print();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            EditWindow itemEdit = new EditWindow();
            itemEdit.SetData(ItemsList[row], row);

            TaskCompletedCallBack callback = UpdateItem;
            itemEdit.SetCallback(callback);

            itemEdit.Show();
        }

        private void dataView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            EditWindow itemEdit = new EditWindow();
            itemEdit.SetData(ItemsList[row], row);

            TaskCompletedCallBack callback = UpdateItem;
            itemEdit.SetCallback(callback);

            itemEdit.Show();
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewRowEventArgs e)
        {
            var row = e.Row.Index;
            EditWindow itemEdit = new EditWindow();
            itemEdit.SetData(ItemsList[row], row);

            TaskCompletedCallBack callback = UpdateItem;
            itemEdit.SetCallback(callback);
        }

        private void BT_NewItem_Click(object sender, EventArgs e)
        {
            EditWindow itemEdit = new EditWindow();

            TaskCompletedCallBack callback = NewItem;
            itemEdit.SetCallback(callback);

            itemEdit.Show();
        }

        private void BT_print_Click(object sender, EventArgs e)
        {
            PrintCurrentData();
        }
    }
}
