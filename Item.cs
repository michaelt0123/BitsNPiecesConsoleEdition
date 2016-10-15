using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsNPieces
{
    /// <summary>
    /// Class: Item
    /// Purpose: Contains the building blocks of an Item.  In this case, all items
    ///          will consist of the following components:
    ///          An integer value called ItemID which would be the unique identifier of the item.
    ///          A string value called ItemName which would be the name or make of the item.
    ///          A string value called ItemType which would be the type or model of the item.
    ///          A DateTime value called ItemExpirationDate which would be the date that the item expires.
    /// </summary>
    class Item
    {
        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public string ItemType { get; set; }

        public DateTime ItemExpirationDate { get; set; }
    }
}
