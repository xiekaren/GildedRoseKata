using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseShould
    {
        [Test]
        public void NotChangeItemName()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("ItemName", items[0].Name);
        }

        [Test]
        public void DegradeQualityByOneWhenSellByDateHasNotPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 1, Quality = 10 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].Quality);
        }

        [Test]
        public void DegradeQualityTwiceAsFastWhenSellByDateHasPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(8, items[0].Quality);
        }

        [Test]
        public void NotDegradeQualityPastZero()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void IncreaseAgedBrieQualityByOneWhenSellInDateNotPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(1, items[0].Quality);
        }

        [Test]
        public void IncreaseAgedBrieQualityTwiceAsFastWhenSellInDateHasPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(2, items[0].Quality);
        }


    }
}
