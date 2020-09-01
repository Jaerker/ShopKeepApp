using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKeepApp.Models
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public float Cost { get; set; }
    }
}
