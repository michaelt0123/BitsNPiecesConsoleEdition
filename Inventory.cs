using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsNPieces
{
    /// <summary>
    /// Class: Inventory
    /// Purpose: Creates a List called inventoryItem that is used to store one or more Items.
    /// Functions: AddItem
    ///            RemoveItem
    ///            ViewItems
    ///            CheckForExpiredItems
    /// </summary>
    class Inventory
    {
        static List<Item> inventoryItem = new List<Item>();

        /// <summary>
        /// Function: AddItem
        /// Description: Used to add an item to the List called inventoryItem.
        /// </summary>
        public static void AddItem()
        {
            try
            {
                //- Add a single item to the inventory via user-inputs for the four
                //- attributes that make up an item.
                inventoryItem.Add(new Item()
                {
                    ItemID = Convert.ToInt32(Console.ReadLine()),
                    ItemName = Console.ReadLine(),
                    ItemType = Console.ReadLine(),
                    ItemExpirationDate = Convert.ToDateTime(Console.ReadLine())
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Function: RemoveItem
        /// Description: Used to remove an item from the List called inventoryItem.
        /// </summary>
        /// <param name="userSelectedItemID"></param>
        public static void RemoveItem(int userSelectedItemID)
        {
            try
            {
                //- Check to see if the selected item exists, then remove it:
                var itemToRemove = inventoryItem.SingleOrDefault(r => r.ItemID == userSelectedItemID);
                if (itemToRemove != null)
                    inventoryItem.Remove(itemToRemove);

                //- Notify the user that the selected item has been removed:
                Console.WriteLine();
                Console.WriteLine("Item Number: " + userSelectedItemID.ToString() + " has been removed.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Function: ViewItems
        /// Description: Used to view the items that are currently in the inventory.
        /// </summary>
        public static void ViewItems()
        {
            try
            {
                //- Loop through the inventory and output the four attributes of each item in the list:
                inventoryItem.ForEach(i => Console.WriteLine(i.ItemID + "\t" + i.ItemName + "\t" + i.ItemType + "\t" + i.ItemExpirationDate));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Function: CheckForExpiredItems
        /// Description: Used to count the number of items in the list that have an expiration
        ///              date that is prior to the current date.
        /// </summary>
        public static void CheckForExpiredItems()
        {
            int expiredItemCount = 0;

            //- Loop through the items in the inventory:
            foreach (Item i in inventoryItem)
            {
                //- Compare the expiration date of each item in the list with today's date:
                if (i.ItemExpirationDate < DateTime.Now)
                {
                    expiredItemCount++;
                }
            }

            if (expiredItemCount > 0)
            {
                Console.WriteLine("There are a total of " + expiredItemCount + " expired items in the inventory.");
            }
            else
            {
                Console.WriteLine("The inventory does not contain any expired items.");
            }
        }
    }
}
