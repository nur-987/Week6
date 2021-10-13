using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore
{
    /// <summary>
    /// let's design a stock and billing software for a hardware store .
    /// </summary>
    class Program
    {
        public static List<Item> itemsList = new List<Item>();
        public static Dictionary<int, Item> shoppingCartDict = new Dictionary<int, Item>();

        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to Store------");
            StartofList();

            //Console.WriteLine("------Adding new Item in Store------");
            //Console.WriteLine("Admin ID?");
            //int tempId = Int32.Parse(Console.ReadLine());
            //IsAdmin(tempId);

            //Console.WriteLine("Item ID?");
            //int itemId = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Item Name?");
            //string itemName = Console.ReadLine();
            //Console.WriteLine("Cost per Item?");
            //int itemCost = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Quantity of Iems in stock?");
            //int itemQuantity = Int32.Parse(Console.ReadLine());
            //AddItemsinStock(itemId, itemName, itemCost, itemQuantity);

            Console.WriteLine("------Buying Item from Store------");
            DisplayAll();

            Console.WriteLine("Item ID to buy?");
            int itemId2 = Int32.Parse(Console.ReadLine());
            AddtoCart(itemId2);

            Console.WriteLine("------Proceed to payment------");



        }

        public static bool IsAdmin(int id)
        {
            Dictionary<int, string> AdminDict = new Dictionary<int, string>();
            if (AdminDict.ContainsKey(id))
            {
                Console.WriteLine("admin check complete, please proceed");
                return true;
            }
            else
            {
                Console.WriteLine("is not an admin! cannot proceed");
                return false;
            }

        }
        public static void AddItemsinStock(int id, string name, int price, int quantity)
        {
            Item item = new Item
            {
                ItemId = id,
                ItemName = name,
                ItemCost = price,
                Quantity = quantity,
            };

            itemsList.Add(item);
            Console.WriteLine("new item added in store!");
            Console.WriteLine("number of items in the store: " + itemsList.Count);

        }

        public static void StartofList()
        {
            Item item1 = new Item
            {
                ItemId = 1,
                ItemName = "hammer",
                ItemCost = 3,
                Quantity = 25,
            };
            Item item2 = new Item
            {
                ItemId = 2,
                ItemName = "ladder",
                ItemCost = 2,
                Quantity = 19,
            };
            Item item3 = new Item
            {
                ItemId = 3,
                ItemName = "hose",
                ItemCost = 5,
                Quantity = 20,
            };
            Item item4 = new Item
            {
                ItemId = 4,
                ItemName = "work boots",
                ItemCost = 6,
                Quantity = 9,
            };

            itemsList.Add(item1);
            itemsList.Add(item2);
            itemsList.Add(item3);
            itemsList.Add(item4);

        }

        public static void DisplayAll()
        {
            foreach (Item item in itemsList)
            {
                if(item.Quantity > 0)
                {
                    Console.WriteLine(item.ItemId);
                    Console.WriteLine(item.ItemName);
                    Console.WriteLine(item.ItemCost);
                }
            }
        }

        public static void AddtoCart(int itemId)
        {
            Customer customer = new Customer
            {
                CustomerId = 1,
            };           

            foreach (Item item in itemsList)
            {
                if(item.ItemId == itemId)
                {
                    shoppingCartDict.Add(customer.CustomerId, item);
                    Console.WriteLine("item added into cart");
                }

            }

        }

        public static void Payment(int custId)
        {
            if (shoppingCartDict.ContainsKey(custId))
            {
                //get the items linked to the key(custId)
                //get the price of the item
            }
        }

    }
}
