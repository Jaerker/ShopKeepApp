using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKeepApp.Models
{
    public class ShopListItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ShopListId { get; set; }

        public int ItemId { get; set; }

        public float Quantity { get; set; }
    }
}
