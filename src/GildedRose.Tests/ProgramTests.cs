using NUnit.Framework;
using GildedRoseEllie.Models;
using System.Collections.Generic;

namespace GildedRoseEllie.Tests
{
    public class ProgramTests
    {
        [Test]
        public void AddItemToInventoryShouldUpdateJsonFile()
        {
            string path = "C:\\MyProjects\\GildedRoseEllie\\GildedRose\\src\\GildedRose.Console\\Inventory.json"; //Directory.GetCurrentDirectory() + @"\Inventory.json";

            var item = new AgedBrie {
                Name = "Aged Brie",
                Quality = 0,
                SellIn = 3
            };

            Inventory.AddItemToInventory(item, path);
            var UpdatedInventory = Inventory.GetInventory(path);

            Assert.That(UpdatedInventory[UpdatedInventory.Count - 1].SellIn == item.SellIn);
            Assert.That(UpdatedInventory[UpdatedInventory.Count - 1].Quality == item.Quality);
            Assert.That(UpdatedInventory[UpdatedInventory.Count - 1].Name == item.Name);
        }

        [Test]
        public void GetInventoryShouldReturnListOfItems()
        {
            string path = "C:\\MyProjects\\GildedRoseEllie\\GildedRose\\src\\GildedRose.Console\\Inventory.json"; //Directory.GetCurrentDirectory() + @"\Inventory.json";
            var InventoryOutput = Inventory.GetInventory(path);

            Assert.IsInstanceOf<List<CustomItem>>(InventoryOutput);
        }

        [Test]
        public void GetItemTypesShoudCorrectInventoryItemType()
        {
            var items = new List<Item>
            {
                 new Item
                 {
                     Name = "Aged Brie",
                     Quality = 0,
                     SellIn = 3
                 },
                new Item
                 {
                     Name = "Aged Brie",
                     Quality = 0,
                     SellIn = 3
                 }
            };
        }
    }
}
