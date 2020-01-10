using GildedRoseEllie;
using GildedRoseEllie.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Tests
{
    public class QualityUpdaterTests
    {
        public IList<IItem> Items;
        public IList<IItem> UpdatedItems;
     
        [TestCase("Aged Brie", 2, 0)]
        public void UpdateQualityShouldIncreaseAgedBrieItemQuality(string name, int sellIn, int quality)
        {
            var ItemWrapper = new AgedBrie { Name = name, SellIn = sellIn, Quality = quality };

            ItemWrapper.UpdateQuality();

            Assert.That(ItemWrapper.Quality == quality + 1);
        }

        [TestCase("+5 Dexterity Vest", 10, 20)]
        public void UpdateQualityShouldReduceSellInValueAndQuality(string name, int sellIn, int quality)
        {
            var ItemWrapper = new StandardItem { Name = name, SellIn = sellIn, Quality = quality };

            ItemWrapper.UpdateQuality();

            //Assert.That(ItemWrapper.SellIn == sellIn - 1);
            Assert.That(ItemWrapper.Quality == quality - 1);
        }

        [TestCase("Elixir of the Mongoose", 0, 7)]
        public void UpdateQualityShouldDegradeOutOfDateItemTwiceAsFast(string name, int sellIn, int quality)
        {
            var ItemWrapper = new StandardItem { Name = name, SellIn = sellIn, Quality = quality };

            ItemWrapper.UpdateQuality();

            Assert.That(ItemWrapper.Quality == quality - 2);
        }

        [TestCase("Elixir of the Mongoose", 0, 7)]
        public void ItemQualityShouldBeLessThan50AndNotBeNegative(string name, int sellIn, int quality)
        {
            var ItemWrapper = new StandardItem { Name = name, SellIn = sellIn, Quality = quality };
            ItemWrapper.UpdateQuality();
            
            Assert.That(ItemWrapper.Quality < 50);
            Assert.That(ItemWrapper.Quality >= 0);
        }


        [Test]
        public void LegendaryItemDoesNotDecreaseInQualityAndNotHaveToBeSold()
        {
            var name = "Sulfuras, Hand of Ragnaros";
            var Item = new LegendaryItem { Name = name };

            Assert.That(Item.Quality == 80);
            //Assert.That(Item.SellIn == int.MaxValue);
        }

        [TestCase("Backstage passes to a TAFKAL80ETC concert", 7, 20)]
        public void BackstagePassesQualityShouldIncreaseBy2WhenSellInIsBetween5and10(string name, int sellIn, int quality)
        {
            var ItemWrapper = new BackstagePass { Name = name, SellIn = sellIn, Quality = quality };
            ItemWrapper.UpdateQuality();

            Assert.That(ItemWrapper.Quality == quality + 2);
        }

        [TestCase("Backstage passes to a TAFKAL80ETC concert", 4, 20)]
        public void BackstagePassesQualityShouldIncreaseBy3WhenSellInIsLessThan5(string name, int sellIn, int quality)
        {
            var ItemWrapper = new BackstagePass { Name = name, SellIn = sellIn, Quality = quality };
            ItemWrapper.UpdateQuality();

            Assert.That(ItemWrapper.Quality == quality + 3);
        }

        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 20)]
        public void BackstagePassesQualityShouldBe0AfterSellInDate(string name, int sellIn, int quality)
        {
            var ItemWrapper = new BackstagePass { Name = name, SellIn = sellIn, Quality = quality };
            ItemWrapper.UpdateQuality();

            Assert.That(ItemWrapper.Quality == 0 );
        }

        [Test]
        public void UpdateQualityShouldDecreaseConjuredItemsQualityBy2()
        {

        }

    }
}