using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Inventario
{
    public partial class Form1 : Form
    {
        PrintDocument facturaPrintDocument;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            string[] datosTabla = { "1", "Producto 1", "10", "20.50" };

            graphics.DrawString("Fecha: " + fecha, font, Brushes.Black, new PointF(100, 100));
            graphics.DrawString("Nombre: " + nombre, font, Brushes.Black, new PointF(100, 120));

            // Ejemplo: Dibujar tabla
            float tablaX = 100;
            float tablaY = 150;
            float celdaAncho = 100;
            float celdaAlto = 20;

            for (int i = 0; i < datosTabla.Length; i++)
            {
                float celdaX = tablaX + (i * celdaAncho);
                graphics.DrawRectangle(Pens.Black, celdaX, tablaY, celdaAncho, celdaAlto);
                graphics.DrawString(datosTabla[i], font, Brushes.Black, new PointF(celdaX, tablaY));
            }
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


    }
}
