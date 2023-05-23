using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    
    public delegate void TaskCompletedCallBack(Item retItem, int row);
    public partial class EditWindow : Form
    {
        string imageLoaded = null;
        TaskCompletedCallBack callback;

        public Item currentItem = new Item();
        int ItemRow = 0;

        public EditWindow()
        {
            InitializeComponent();
        }

        public void SetData(Item item, int row)
        {
            Inventory.ClearTemp();
            this.
            currentItem = item;
            ItemRow = row;
            ProductID.Text = currentItem.ID.ToString();
            itemName.Text = currentItem.Name;
            itemManufacturer.Text = currentItem.Manufacturer;
            itemProvider.Text = currentItem.Provider;
            PriceValue.Value = (decimal)currentItem.Price;
            SellPriceValue.Value = (decimal)currentItem.SellPrice;
            itemDesc.Text = currentItem.Description;

            if (currentItem.IconPath != null)
            {
                if (File.Exists(currentItem.IconPath))
                {
                    if(!Directory.Exists(Path.Combine(Path.GetTempPath(), "ElciInventory")))
                    { 
                        Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), "ElciInventory"));
                    }
                    string tempImagePath = Path.Combine(Path.GetTempPath(),"ElciInventory", Guid.NewGuid().ToString());
                    File.Copy(currentItem.IconPath, tempImagePath, true);
                    itemPicture.Image = Image.FromFile(tempImagePath);
                }
            }

        }

        public void Save()
        {
            
            currentItem.Name = itemName.Text;
            currentItem.Manufacturer = itemManufacturer.Text;
            currentItem.Provider = itemProvider.Text;
            currentItem.Price = (float)PriceValue.Value;
            currentItem.SellPrice = (float)SellPriceValue.Value;
            currentItem.Description = itemDesc.Text;
            if (currentItem.ID == "")
                currentItem.ID = GenerateID(currentItem);

            if (imageLoaded != null)
            {
                SaveImage();
            }

            if (callback != null)
            {
                callback(currentItem, ItemRow);
            }

            this.Dispose();
        }

        void SaveImage()
        {
            string ext = Path.GetExtension(imageLoaded);
            string carpetaDestino = Path.Combine(Application.StartupPath, "ItemImages");
            string rutaDestino = Path.Combine(carpetaDestino, currentItem.ID);

            string[] archivosEnDirectorio = Directory.GetFiles(carpetaDestino, currentItem.ID + ".*");

            foreach (string archivo in archivosEnDirectorio)
            {
                try
                {
                    File.Delete(archivo);
                }
                catch(Exception e)
                { }
            }

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            File.Copy(imageLoaded, rutaDestino, true);

            currentItem.IconPath = rutaDestino;
        }

        public static string GenerateID(Item item)
        {
            string initials = string.Empty;

            if (item.Name.Length > 2)
            {
                initials += item.Name.ToUpper().Substring(0, 2);
            }

            if (item.Manufacturer.Length > 2)
            {
                initials += item.Manufacturer.ToUpper().Substring(0, 2);
            }

            if (item.Provider.Length > 2)
            {
                initials += item.Provider.ToUpper().Substring(0, 2);
            }

            // Generar un número aleatorio de 4 dígitos
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);

            // Combinar las iniciales y el número aleatorio
            string generatedID = $"{initials}{randomNumber}";

            // Verificar si el ID generado tiene más de 7 dígitos
            if (generatedID.Length > 7)
            {
                // Acortar el ID para que tenga solo 7 dígitos
                generatedID = generatedID.Substring(0, 8);
            }

            return generatedID;
        }

        public void SetCallback(TaskCompletedCallBack cb)
        {
            callback = cb;
        }

        private void EditWindow_Load(object sender, EventArgs e)
        {

        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void itemPicture_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLoaded = openFileDialog.FileName;
                    itemPicture.Image = Image.FromFile(imageLoaded);
                }
            }
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
