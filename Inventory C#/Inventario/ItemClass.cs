using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario 
{
    [Serializable]
    public class Item : INotifyPropertyChanged
    {
        public string ID { get; set; }

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

}
}
