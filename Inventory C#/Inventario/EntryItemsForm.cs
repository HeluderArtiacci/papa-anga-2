using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario
{
    public partial class EntryItemsForm : Form
    {

        List<string> dropDownList = new List<string> ();

        public BindingList<EntryData> ViewList = new BindingList<EntryData> ();
        public EntryItemsForm()
        {
            InitializeComponent();
        }

        private void EntryItemsForm_Load(object sender, EventArgs e)
        {

            dataView.DataSource = ViewList;


            foreach (Item myitem in Inventory.ItemsList)
            {
                var itemData = $"[{myitem.ID}] | {myitem.Name}";
                dropDownList.Add(itemData);
                itemsDropDown.Items.Add(itemData);
            }
        }

        private void itemsDropDown_TextChanged(object sender, EventArgs e)
        {
            string searchText = itemsDropDown.Text.ToLower();
            itemsDropDown.Items.Clear();

            // Filtra los elementos de acuerdo con el texto ingresado por el usuario
            foreach (string item in dropDownList)
            {
                if (item.ToLower().Contains(searchText))
                {
                    itemsDropDown.Items.Add(item);
                }
            }

            itemsDropDown.DroppedDown = true; // Muestra el cuadro desplegable con los resultados filtrados
            itemsDropDown.SelectionStart = searchText.Length; // Establece el punto de inserción del texto en el ComboBox
        }
    }
}
