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
        public static DataBase MyDataBase = new DataBase();

        public static Dictionary<string, Item> ItemsListDic = new Dictionary<string, Item>();

        private SoundPlayer soundPlayer;

        public Form ItemsForm = null;

        private DateTime startTime;

        public System.Windows.Forms.Timer timer = null;

        public static BindingList<Item> ItemsList = new BindingList<Item>(); 
        public static BindingList<EntryData> EntriesData = new BindingList<EntryData>();
        public static BindingList<ExitData> ExitsData = new BindingList<ExitData>();
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
                //ItemsList = new BindingList<Item>(TestList());
                SaveDataBase();
            }

            timer = new System.Windows.Forms.Timer();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            sesionTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        public static void UpdateDictionary()
        {
            ItemsListDic = new Dictionary<string, Item>();
            foreach (Item myitem in ItemsList)
            {
                ItemsListDic[myitem.ID] = myitem;
            }
        }

        public List<Item> TestList()
        {
            var retList = new List<Item>();
            retList.Add(new Item()
            {
                ID = "DONARA25",
                Name = "Dorilocos",
                Manufacturer = "Navis",
                Provider = "rascct",
                Description = "adsdda",
                Price = (float)1.5,
                SellPrice = 1.75f,
                inStockCount = (int)GenerateRandomFloat(1, 50)

            }); ;

            retList.Add(new Item()
            {
                ID = "PEREYA14",
                Name = "Pesi",
                Manufacturer = "Resvis",
                Provider = "Yascct",
                Description = "qwerts",
                Price = (float)0.5,
                SellPrice = 0.75f,
                inStockCount = (int)GenerateRandomFloat(1, 50)
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
                item.inStockCount = (int)GenerateRandomFloat(1, 50);

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

            MyDataBase.EntriesData = EntriesData ;
            MyDataBase.ExitsData = ExitsData;
            MyDataBase.ItemsList = ItemsList;

            // Serializar la lista en un archivo binario
            using (FileStream fs = new FileStream("database.bin", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, MyDataBase);
            }

            LoadDataBase();
        }

        public static Item GetItem(string id)
        {
            try
            {
                return ItemsListDic[id];
            }
            catch
            {
                return null;
            }
        }

        public static int GetItemCount(string id)
        {
            if (GetItem(id) != null)
                return GetItem(id).inStockCount;
            else
                return 0;
        }
        public static void SetItemCount(string id, int Count)
        {
            if(GetItem(id) != null)
                ItemsList[ItemsList.IndexOf(GetItem(id))].inStockCount = Count;

        }

        public static void LoadDataBase()
        {
            // Deserializar la lista desde el archivo binario
            using (FileStream fs = new FileStream("database.bin", FileMode.Open))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    MyDataBase = (DataBase)formatter.Deserialize(fs);
                }
                catch {
                    MessageBox.Show("Los datos no pudieron ser cargados."); return; }

                EntriesData = MyDataBase.EntriesData;
                ExitsData = MyDataBase.ExitsData;
                ItemsList = MyDataBase.ItemsList;
            }
            UpdateDictionary();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualSesionDate.Text = DateTime.Now.ToString();

            startTime = DateTime.Now;
            timer.Start();

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
            DisposeOthers();
            if (ItemsForm == null)
            {
                ItemsForm = new ExitItemsForm() { TopLevel = false, TopMost = true };
                ItemsForm.FormBorderStyle = FormBorderStyle.None;
                ChildFormPanel.Controls.Add(ItemsForm);
                ItemsForm.Show();
            }
            else { MessageBox.Show("Already  created!"); }
        }

        void DisposeOthers()
        {
            if (ItemsForm != null)
            {
                ItemsForm.Dispose();
                ItemsForm = null;
            }

            var soundStream = Properties.Resources.buttonClick;

            // Crea una instancia de SoundPlayer utilizando el flujo de recursos
            soundPlayer = new SoundPlayer(soundStream);

            // Reproduce el sonido
            soundPlayer.Play();
        }

        private void BT_CheckIn_Click(object sender, EventArgs e)
        {
            DisposeOthers();
            if (ItemsForm == null)
            {
                ItemsForm = new BillingForm() { TopLevel = false, TopMost = true };
                ItemsForm.FormBorderStyle = FormBorderStyle.None;
                ChildFormPanel.Controls.Add(ItemsForm);
                ItemsForm.Show();
            }
            else { MessageBox.Show("Already  created!"); }
        }
    }
}
