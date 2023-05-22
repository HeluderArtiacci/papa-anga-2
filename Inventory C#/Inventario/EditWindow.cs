using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public delegate void TaskCompletedCallBack(Item retItem, int row);
    public partial class EditWindow : Form
    {

        TaskCompletedCallBack callback;

        public Item currentItem = new Item();
        int ItemRow = 0;

        public EditWindow()
        {
            InitializeComponent();
        }

        public void SetData(Item item, int row)
        {
            currentItem = item;
            ItemRow = row;
            ProductID.Text = currentItem.ID.ToString();
            itemName.Text = currentItem.Name;
            itemManufacturer.Text = currentItem.Manufacturer;
            itemProvider.Text = currentItem.Provider;
            PriceValue.Value = (decimal)currentItem.Price;
            SellPriceValue.Value = (decimal)currentItem.SellPrice;
        }

        public void Save()
        {
            if (currentItem.ID == "")
                currentItem.ID = GenerateID();
            currentItem.Name = itemName.Text;
            currentItem.Manufacturer = itemManufacturer.Text;
            currentItem.Provider = itemProvider.Text;
            currentItem.Price = (float)PriceValue.Value;
            currentItem.SellPrice = (float)SellPriceValue.Value;

            if (callback != null)
            {
                callback(currentItem, ItemRow);
            }

            this.Dispose();
        }

        public string GenerateID()
        {
            string initials = $"{itemName.Text.ToUpper().Substring(0, 2)}{itemManufacturer.Text.ToUpper().Substring(0, 2)}{itemProvider.Text.ToUpper().Substring(0, 2)}";

            // Generar un número aleatorio de 4 dígitos
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
