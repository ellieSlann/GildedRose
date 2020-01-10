using System;
using System.Collections.Generic;
using GildedRoseEllie.Models;
using System.Linq;

namespace GildedRoseEllie
{
    public static class Program
    {
        private static IList<IItem> items;
        public static List<IItem> customItems;


        public static void Main()
        {
            Console.WriteLine("OMGHAI!");

            var path = @"C:\MyProjects\GildedRoseEllie\GildedRose\src\GildedRose.Console\Inventory.json";

            customItems = Inventory.GetInventory(path);

            foreach (var Item in customItems.OfType<StandardItem>())
            {
                if (!Validation.ValidateQuality(Item)) throw new IndexOutOfRangeException("Quality must be between 0 and 50");
                Item.UpdateItem();
            }

            foreach (var item in customItems)
            {
                Console.WriteLine($"Name: {item.Name} SellIn: {item.SellIn} Quality: {item.Quality}");
            }

            //Console.WriteLine("Do you want to add an item to the inventory?");

            //var updateRequest = Console.ReadKey();
            //if (updateRequest == "Y")
            //{
            //    //ToDo add items request
            //to do: include validation
            //}
        }
    }
}   
