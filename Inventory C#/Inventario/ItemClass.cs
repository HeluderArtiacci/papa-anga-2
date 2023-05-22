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
    public class Item
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float SellPrice { get; set; }
        public string Manufacturer { get; set; }
        public string Provider { get; set; }
        [Browsable(false)] public string Description { get; set; }
        [Browsable(false)] public string IconPath { get; set; }

        public Item()
        {
            ID = "";
            Name = "";
            Price = 0;
            SellPrice =0;
            IconPath = "";

        }

    }
}
