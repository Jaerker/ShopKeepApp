using SQLite;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ShopKeepApp.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string ShopListName { get; set; }

        public string Comment { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime FinishedTime { get; set; }

    }
}
