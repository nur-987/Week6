using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore
{
    class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemCost { get; set; }
        public int Quantity { get; set; }
    }

    class Customer
    {
        public int CustomerId { get; set; }
    }
    class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
    }
}
