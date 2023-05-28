using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inventario
{
    [Serializable]
    public class DataBase
    {
        public BindingList<Item> ItemsList = new BindingList<Item>();
        public BindingList<EntryData> EntriesData = new BindingList<EntryData>();
    }

    [Serializable]
    public class EntryData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public BindingList<EntryItem> Items = new BindingList<EntryItem>();

    }
    [Serializable]
    public class EntryItem
    {
        public string ItemID { get; set; }
        public int Count { get; set; }

        public EntryItem(string itemID, int count)
        {
            ItemID = itemID;
            Count = count;
        }
    }

    [Serializable]
    public class ExitData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public string clientName;
        public string clientDNI; 
        public string clientAddress;
        public BindingList<ExitItem> Items = new BindingList<ExitItem>();

    }
    [Serializable]
    public class ExitItem
    {
        public string ItemID { get; set; }
        public int Count { get; set; }

        public ExitItem(string itemID, int count)
        {
            ItemID = itemID;
            Count = count;
        }
    }

    [Serializable]
    public class Item : INotifyPropertyChanged
    {
        public string ID { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public float Price { get; set; }
        public float SellPrice { get; set; }
        public string Manufacturer { get; set; }
        public string Provider { get; set; }
        [Browsable(false)] public string Description { get; set; }
        [Browsable(false)] public string IconPath { get; set; }
        public int inStockCount { get; set; }

        public Item()
        {
            ID = "";
            Name = "";
            Price = 0;
            SellPrice =0;
            IconPath = "";
            inStockCount = 0;
        }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Define las propiedades de Item
    // ...

    // En cada propiedad, llama a OnPropertyChanged en el setter
    // por ejemplo:
    

}
}
