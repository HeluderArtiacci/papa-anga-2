using Inventario.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Inventario
{
    public partial class EntryItemsForm : Form
    {

        List<string> ItemsdropDownList = new List<string> ();
        List<string> EntriesdropDownList = new List<string>();
        private int currentData;
        private int currentItem;
        public EntryItemsForm()
        {
            InitializeComponent();
        }

        private void EntryItemsForm_Load(object sender, EventArgs e)
        {

            foreach (Item myitem in Inventory.ItemsList)
            {
                var itemData = $"[{myitem.ID}] | {myitem.Name}";
                ItemsdropDownList.Add(itemData);
                itemsDropDown.Items.Add(itemData);
            }
            dataView.Columns.Add("Code", "ID");
            dataView.Columns.Add("Name", "Nombre");
            dataView.Columns.Add("Price", "Precio");
            dataView.Columns.Add("SellPrice", "Precio de venta");
            dataView.Columns.Add("Count", "Cantidad");
            dataView.Columns.Add("Total", "Total");

            dataView.CellFormatting += dataView_CellFormatting;

            UpdateEntriesDropDown();
            EditPanel.Enabled = false;
        }
        private void dataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dataView.Columns["Price"].Index || e.ColumnIndex == dataView.Columns["SellPrice"].Index || e.ColumnIndex == dataView.Columns["Total"].Index) && e.Value != null)
            {
                float price = (float)e.Value;
                e.Value = $"${price.ToString("0.00")}";
                e.FormattingApplied = true;
            }
        }

        public void UpdateEntriesDropDown()
        {
            EntriesdropDownList = new List<string>();
            entriesDropDown.Items.Clear();

            foreach (EntryData entry in Inventory.EntriesData)
            {
                var entrieData = $"[{entry.Id}] | {entry.Name} | {entry.date}";
                EntriesdropDownList.Add(entrieData);
                entriesDropDown.Items.Add(entrieData);
            }
        }

        public void SetDataView(EntryData data)
        {
            if (data != null)
            {
                EditPanel.Enabled = true;

                currentData = Inventory.EntriesData.IndexOf(data);
                entryNameFill.Text = data.Name;
                EntryDate.SetDate(data.date);

                dataView.Rows.Clear();
                if (data.Items != null)
                {
                    foreach (EntryItem item in data.Items)
                    {
                        var newItem = dataView.Rows.Add();
                        foreach (Item myitem in Inventory.ItemsList)
                        {
                            if (myitem.ID == item.ItemID)
                            {
                                dataView.Rows[newItem].Cells[0].Value = myitem.ID;
                                dataView.Rows[newItem].Cells[1].Value = myitem.Name;
                                dataView.Rows[newItem].Cells[2].Value = myitem.Price;
                                dataView.Rows[newItem].Cells[3].Value = myitem.SellPrice;
                                dataView.Rows[newItem].Cells[4].Value = item.Count;
                                dataView.Rows[newItem].Cells[5].Value = myitem.Price * item.Count;
                            }
                        }



                    }
                }
            }
            else
            {
                EditPanel.Enabled = false;
                entryNameFill.Text = "";
                dataView.Rows.Clear();

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
            itemCode.Text = currentItem.ID;
            priceLabel.Text = $"${currentItem.Price}";
            sellPriceLabel.Text = $"${currentItem.SellPrice}";
        }


        private void itemsDropDown_TextChanged(object sender, EventArgs e)
        {
            itemsDropDown.DroppedDown = false;
            string searchText = itemsDropDown.Text.ToLower();
            itemsDropDown.Items.Clear();

            // Filtra los elementos de acuerdo con el texto ingresado por el usuario
            foreach (string item in ItemsdropDownList)
            {
                if (item.ToLower().Contains(searchText))
                {
                    itemsDropDown.Items.Add(item);
                }
            }

            itemsDropDown.DroppedDown = true; // Muestra el cuadro desplegable con los resultados filtrados
            itemsDropDown.SelectionStart = searchText.Length; // Establece el punto de inserción del texto en el ComboBox
        }

        private void BT_NewEntry_Click(object sender, EventArgs e)
        {
            EntryData newEntry = new EntryData();
            newEntry.date = DateTime.Today;
            newEntry.Name = "NewDate";
            Inventory.EntriesData.Add(newEntry);
            newEntry.Id = Inventory.EntriesData.IndexOf(newEntry);
            UpdateEntriesDropDown();
            entriesDropDown.SelectedIndex = newEntry.Id;
            SetDataView(Inventory.EntriesData[newEntry.Id]);

        }

        private void entriesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entriesDropDown.SelectedIndex != -1)
                SetDataView(Inventory.EntriesData[entriesDropDown.SelectedIndex]);
            else
                SetDataView(null);
        }

        private void itemsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(string check in ItemsdropDownList)
            {
                if(check == itemsDropDown.Text)
                {
                    var index = ItemsdropDownList.IndexOf(check);
                    SetItemPreview(Inventory.ItemsList[index]);
                    currentItem = index;
                }
            }
        }

        private void BT_AddProduct_Click(object sender, EventArgs e)
        {
            Inventory.EntriesData[currentData].Items.Add(new EntryItem(Inventory.ItemsList[currentItem].ID, (int)productCount.Value));
            SetDataView(Inventory.EntriesData[currentData]);
        }
    }
}
