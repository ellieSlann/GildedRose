using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System;
using GildedRoseEllie.Models;

namespace GildedRoseEllie
{
    public static class Inventory
    {
        public static List<CustomItem> GetInventory(string path)
        {

            if (File.Exists(path))
            {
                var streamReader = new StreamReader(path);
                var content = streamReader.ReadToEnd();

                var Inventory = JsonConvert.DeserializeObject<List<CustomItem>>(content);
                streamReader.Close();
                return Inventory;
            }
            return new List<CustomItem>();
        }

        public static void AddItemToInventory(CustomItem item, string path)
        {
            //var newItem = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };

            //if (ValidateQuality(newItem)) Items.Add(newItem);
            //else Console.WriteLine("Item is not valid");

            var Inventory = GetInventory(path);

            try
            {
                if (File.Exists(path)) File.Delete(path);
                else Debug.WriteLine("File does not exist");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Inventory.Add(item);

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JsonConvert.SerializeObject(Inventory));
                tw.Close();
            }

        }
    }
}   
