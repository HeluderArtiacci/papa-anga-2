using Inventario.Properties;
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
    public partial class ExitItemsForm : Form
    {

        Dictionary<string, string> ItemsList = new Dictionary<string, string>();
        List<string> ItemsdropDownList = new List<string>();
        List<string> EntriesdropDownList = new List<string>();
        private int currentData;
        private int currentItem;
        private ExitData newExit = null;
        public bool CanAdd = true;
        public Item selectedItem;
        public ExitItemsForm()
        {
            InitializeComponent();
        }

        private void ExitItems_Load(object sender, EventArgs e)
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

            foreach (ExitData Exit in Inventory.EntriesData)
            {
                var entrieData = $"[{Exit.Id}] | {Exit.Name} | {Exit.date}";
                EntriesdropDownList.Add(entrieData);
                entriesDropDown.Items.Add(entrieData);
            }
        }*/

        public void ResetEditMenu()
        {

            ExitNameLabel.Text = "";
            ExitNameFill.Text = "";
            TotalLabel.Text = "$ 0";
            SetItemPreview(new Item());
        }
        public void SetDataView(ExitData data)
        {
            if (data != null)
            {
                ExitNameLabel.Text = data.Name;
                EditPanel.Enabled = true;
                currentData = Inventory.ExitsData.IndexOf(data);
                ExitNameFill.Text = data.Name;
                ExitDate.SetDate(data.date);
                dataView.Rows.Clear();
                float Total = 0;
                if (data.Items != null)
                {
                    foreach (ExitItem item in data.Items)
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
                                dataView.Rows[newItem].Cells[5].Value = myitem.SellPrice * item.Count;
                                Total += myitem.SellPrice * item.Count;
                            }
                        }
                    }
                    TotalLabel.Text = "$ " + String.Format("{0:0.00}", Total);
                }
            }
            else
            {
                EditPanel.Enabled = false;
                ExitNameFill.Text = "";
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
            nameLabel.Text = currentItem.Name;
            itemCode.Text = currentItem.ID;
            sellPriceLabel.Text = $"${currentItem.SellPrice}";
        }


        private void BT_NewExit_Click(object sender, EventArgs e)
        {
            if (newExit == null)
            {
                newExit = new ExitData();
                newExit.date = DateTime.Today;
                newExit.Name = "NewSell_" + Inventory.ExitsData.Count.ToString();
                SetDataView(newExit);
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
                    newExit = new ExitData();
                    newExit.date = DateTime.Today;
                    newExit.Name = "NewSell_" + Inventory.ExitsData.Count.ToString();
                    SetDataView(newExit);
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
            if (itemsDropDown.SelectedIndex != -1 && currentItem != -1 && CanAdd)
            {
                newExit.Items.Add(new ExitItem(Inventory.ItemsList[currentItem].ID, (int)productCount.Value));
                SetDataView(newExit);
                SetItemPreview(selectedItem);
            }
            else
            {
                System.Media.SystemSounds.Hand.Play();
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
                    selectedItem = Inventory.ItemsList[index];
                    productCount.Value = 1;
                    currentItem = index;
                    CheckStock();
                }
            }

            if (selectedItem != null)
            {
                var Subtotal = (selectedItem.SellPrice * (int)productCount.Value);
                CheckStock();
                SubTotalLabel.Text = "$ " + String.Format("{0:0.00}", Subtotal);
            }

        }

        private void ExitNameFill_TextChanged(object sender, EventArgs e)
        {
            if (newExit != null)
            {
                newExit.Name = ExitNameFill.Text;
                newExit.clientName = clientNameFill.Text;
                newExit.clientAddress = addresClientFill.Text;
                newExit.clientDNI = DNIclientFill.Text;
                ExitNameLabel.Text = ExitNameFill.Text;
            }
        }

        private void BT_saveExit_Click(object sender, EventArgs e)
        {
            if (newExit != null)
            {
                if (newExit.Items.Count >= 1)
                {
                    MessageBox.Show("Entrada registrada!");
                    Inventory.ExitsData.Add(newExit);
                    foreach (ExitItem item in newExit.Items)
                    {
                        int currentCount = Inventory.GetItemCount(item.ItemID);
                        Inventory.SetItemCount(item.ItemID, currentCount - item.Count);
                    }
                    newExit = null;

                    EditPanel.Enabled = false;
                    dataView.Rows.Clear();
                    ExitNameLabel.Text = "";
                    ExitNameFill.Text = "";
                    TotalLabel.Text = "$ 0";
                    SetItemPreview(new Item());
                    itemsDropDown.Text = "";
                    itemsDropDown.SelectedIndex = -1;
                    productCount.Value = 1;
                    productCount.ForeColor = Color.Black;
                    clientNameFill.Text = "";
                    DNIclientFill.Text = "";
                    addresClientFill.Text = "";
                    Inventory.SaveDataBase();


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

        private void stockLabel_Click(object sender, EventArgs e)
        {

        }

        private void productCount_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                var Subtotal = (selectedItem.SellPrice * (int)productCount.Value);
                CheckStock();
                SubTotalLabel.Text = "$ " + String.Format("{0:0.00}", Subtotal);
            }
        }

        public void CheckStock()
        {
            if (productCount.Value > selectedItem.inStockCount)
            {
                productCount.ForeColor = Color.Red;
                stockLabel.ForeColor = Color.Red;
                stockLabelName.ForeColor = Color.Red;
                CanAdd = false;
            }
            else
            {
                productCount.ForeColor = Color.Black;
                stockLabel.ForeColor = Color.Black;
                stockLabelName.ForeColor = Color.Black;
                CanAdd = true;
            }
        }

        private void ExitDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (newExit != null)
                {
                    newExit.date = ExitDate.SelectionStart;
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
