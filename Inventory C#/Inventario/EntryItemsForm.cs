using Inventario.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario
{
    public partial class EntryItemsForm : Form
    {
        Dictionary<string, string> ItemsList = new Dictionary<string, string>();
        List<string> ItemsdropDownList = new List<string> ();
        List<string> EntriesdropDownList = new List<string>();
        private int currentData;
        private int currentItem = -1;
        public string EntryName = "";

        Item selectedItem = null; 
        private EntryData newEntry = null;
        public EntryItemsForm()
        {
            InitializeComponent();
        }

        private void EntryItemsForm_Load(object sender, EventArgs e)
        {

            foreach (Item myitem in Inventory.ItemsList)
            {
                var itemData = $"[{myitem.ID}] | {myitem.Name}";
                ItemsList[myitem.ID] = itemData;
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

            //UpdateEntriesDropDown();
            EditPanel.Enabled = false;
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
        /*
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
        }*/

        public void SetDataView(EntryData data)
        {
            if (data != null)
            {
                EntryNameLabel.Text = data.Name;
                EditPanel.Enabled = true;
                currentData = Inventory.EntriesData.IndexOf(data);
                entryNameFill.Text = data.Name;
                EntryDate.SetDate(data.date);
                dataView.Rows.Clear();
                float Total = 0;
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
                                Total += myitem.Price * item.Count;
                            }
                        }
                    }
                    TotalLabel.Text = "$ " + String.Format("{0:0.00}",Total);
                }
            }
            else
            {
                EditPanel.Enabled = false;
                entryNameFill.Text = "";
                dataView.Rows.Clear();
                TotalLabel.Text = "$ 0";
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
            stockLabel.Text = currentItem.inStockCount.ToString();
            selectedItem = currentItem;
            nameLabel.Text = currentItem.Name;
            itemCode.Text = currentItem.ID;
            priceLabel.Text = $"${currentItem.Price}";
            sellPriceLabel.Text = $"${currentItem.SellPrice}";
            productCount.Value = 1;
        }


        private void BT_NewEntry_Click(object sender, EventArgs e)
        {
            if (newEntry == null)
            {
                newEntry = new EntryData();
                newEntry.date = DateTime.Today;
                newEntry.Name = "NewEntry_" + Inventory.EntriesData.Count.ToString();
                SetDataView(newEntry);
                TotalLabel.Text = "$ 0";
                SetItemPreview(new Item());
                itemsDropDown.TabIndex = 0;
                productCount.Value = 1;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea Descartar y crear un nuevo registro de entrada?", "Confirmar operacion.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    newEntry = new EntryData();
                    newEntry.date = DateTime.Today;
                    newEntry.Name = "NewEntry_" + Inventory.EntriesData.Count.ToString();
                    SetDataView(newEntry);
                    TotalLabel.Text = "$ 0";
                    SetItemPreview(new Item());
                    itemsDropDown.TabIndex = 0;
                    productCount.Value = 1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }

        }
        /*
        private void entriesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entriesDropDown.SelectedIndex != -1)
                SetDataView(Inventory.EntriesData[entriesDropDown.SelectedIndex]);
            else
                SetDataView(null);
        }*/

        private void BT_AddProduct_Click(object sender, EventArgs e)
        {
            if (itemsDropDown.SelectedIndex != -1 && currentItem != -1)
            {
                newEntry.Items.Add(new EntryItem(Inventory.ItemsList[currentItem].ID, (int)productCount.Value));
                SetDataView(newEntry);
            }
        }

        private void itemsDropDown_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterItems_TextChanged(object sender, EventArgs e)
        {

            string searchText = filterItems.Text.ToLower();
            itemsDropDown.Items.Clear();

            // Filtra los elementos de acuerdo con el texto ingresado por el usuario
            foreach (string item in ItemsdropDownList)
            {
                if (item.ToLower().Contains(searchText))
                {
                    itemsDropDown.Items.Add(item);
                }
            }
        }

        private void itemsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string check in ItemsdropDownList)
            {
                if (check == itemsDropDown.Text)
                {
                    var index = ItemsdropDownList.IndexOf(check);
                    SetItemPreview(Inventory.ItemsList[index]);
                    currentItem = index;
                }
            }

            if (selectedItem != null)
            {
                var Subtotal = (selectedItem.Price * (int)productCount.Value);
                SubTotalLabel.Text = "$ " + String.Format("{0:0.00}", Subtotal);
            }
        }

        private void entryNameFill_TextChanged(object sender, EventArgs e)
        {
            if(newEntry != null)
            {
                EntryName = entryNameFill.Text;
                newEntry.Name = EntryName;
                EntryNameLabel.Text = entryNameFill.Text;
                
            }
        }

        private void BT_saveEntry_Click(object sender, EventArgs e)
        {
            if (newEntry != null)
            {
                if (newEntry.Items.Count >= 1)
                {
                    MessageBox.Show("Entrada registrada!");
                    newEntry.Name = EntryName;
                    Inventory.EntriesData.Add(newEntry);
                    foreach (EntryItem item in newEntry.Items)
                    {
                        int currentCount = Inventory.GetItemCount(item.ItemID);
                        Inventory.SetItemCount(item.ItemID, currentCount + item.Count);
                    }
                    Inventory.SaveDataBase();

                    newEntry = null;


                    EditPanel.Enabled = false;
                    dataView.Rows.Clear();
                    EntryNameLabel.Text = "";
                    entryNameFill.Text = "";
                    TotalLabel.Text = "$ 0";
                    SetItemPreview(new Item());
                    itemsDropDown.TabIndex = 0;
                    productCount.Value = 1;                    
                }
                else
                {
                    MessageBox.Show("Registro sin productos!");
                }
            }
            else
            {

            }
        }

        private void productCount_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem != null) {
                var Subtotal = (selectedItem.Price * (int)productCount.Value);

                SubTotalLabel.Text = "$ " + String.Format("{0:0.00}", Subtotal);
            }
        }

        private void EntryDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (newEntry != null)
            {
                newEntry.date = EntryDate.SelectionStart;
            }
        }

        private void BT_cancelEntry_Click(object sender, EventArgs e)
        {
            if (newEntry != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea descartar el registro de entrada?", "Confirmar operacion.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    newEntry = null;
                    SetDataView(newEntry);
                    TotalLabel.Text = "$ 0";
                    SetItemPreview(new Item());
                    itemsDropDown.SelectedIndex = -1;
                    itemsDropDown.TabIndex = 0;
                    itemsDropDown.Text = "";
                    productCount.Value = 1;
                    EntryNameLabel.Text = "";
                    SubTotalLabel.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}
