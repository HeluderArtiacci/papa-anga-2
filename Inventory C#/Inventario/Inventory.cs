using Inventario.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;


namespace Inventario
{
    public partial class Inventory : Form
    {
        private SoundPlayer soundPlayer;

        public Form ItemsForm = null;

        public static BindingList<Item> ItemsList = new BindingList<Item>(); 
        public static BindingList<EntryData> EntriesData = new BindingList<EntryData>();

        static Random random = new Random();
        public Inventory()
        {
            InitializeComponent();
            

            if (File.Exists("database.bin"))
            {
                // Cargar los datos guardados
                LoadDataBase();

            }
            else
            {
                ItemsList = new BindingList<Item>(TestList());
            }

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
                Price = (float)1.5,
                SellPrice = 1.75f
            });

            retList.Add(new Item()
            {
                ID = "",
                Name = "Pesi",
                Manufacturer = "Resvis",
                Provider = "Yascct",
                Description = "qwerts",
                Price = (float)0.5,
                SellPrice = 0.75f
            });

            for (int i = 0; i < 100; i++)
            {
                Item item = new Item();

                // Generar datos aleatorios coherentes
                item.Name = GenerateRandomString(8);
                item.Manufacturer = GenerateRandomString(6);
                item.Provider = GenerateRandomString(7);
                item.Description = GenerateRandomString(30);
                item.Price = GenerateRandomFloat(0.5f, 10f);
                item.SellPrice = GenerateRandomFloat(item.Price, 12f);

                // Generar y asignar la ID
                item.ID = EditWindow.GenerateID(item);

                retList.Add(item);
            }

            return retList;
        }

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static float GenerateRandomFloat(float minValue, float maxValue)
        {
            float randomValue = (float)(random.NextDouble() * (maxValue - minValue) + minValue);
            return (float)Math.Round(randomValue, 2);
        }

        public static void SaveDataBase()
        {

            // Serializar la lista en un archivo binario
            using (FileStream fs = new FileStream("database.bin", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, ItemsList);
            }

            MessageBox.Show("Datos guardados correctamente.");
        }

        public static void LoadDataBase()
        {
            // Deserializar la lista desde el archivo binario
            using (FileStream fs = new FileStream("database.bin", FileMode.Open))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsList = (BindingList<Item>)formatter.Deserialize(fs);
                }
                catch {
                    MessageBox.Show("Los datos no pudieron ser cargados."); return; }
            }

            MessageBox.Show("Datos cargados correctamente.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Vaciar el contenido de la carpeta temporal
            ClearTemp();
        }

        public static void ClearTemp()
        {
            string tempFolderPath = Path.Combine(Path.GetTempPath(), "ElciInventory");

            if (Directory.Exists(tempFolderPath))
            {
                string[] tempFiles = Directory.GetFiles(tempFolderPath);

                foreach (string file in tempFiles)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch { }
                }
            }           
        }

        private void BT_Items_Click(object sender, EventArgs e)
        {
            DisposeOthers();
            if (ItemsForm == null)
            {
                ItemsForm = new ItemControlForm() { TopLevel = false, TopMost = true };
                ItemsForm.FormBorderStyle = FormBorderStyle.None;
                ChildFormPanel.Controls.Add(ItemsForm);
                ItemsForm.Show();
            }
            else { MessageBox.Show("Already  created!"); }
        }

        private void BT_EntryItems_Click(object sender, EventArgs e)
        {
            DisposeOthers();
            if (ItemsForm == null)
            {
                ItemsForm = new EntryItemsForm() { TopLevel = false, TopMost = true };
                ItemsForm.FormBorderStyle = FormBorderStyle.None;
                ChildFormPanel.Controls.Add(ItemsForm);
                ItemsForm.Show();
            }
            else { MessageBox.Show("Already  created!"); }
            
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeOthers();
        }

        private void BT_ExitItems_Click(object sender, EventArgs e)
        {
            
        }

        void DisposeOthers()
        {
            if (ItemsForm != null)
            {
                ItemsForm.Dispose();
                ItemsForm = null;
            }

            var soundStream = Properties.Resources.nose;

            // Crea una instancia de SoundPlayer utilizando el flujo de recursos
            soundPlayer = new SoundPlayer(soundStream);

            // Reproduce el sonido
            soundPlayer.Play();
        }

        private void BT_CheckIn_Click(object sender, EventArgs e)
        {

            DisposeOthers();
        }
    }
}
