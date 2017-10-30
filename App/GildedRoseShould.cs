using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseShould
    {
        [Test]
        public void DegradeQualityByOneWhenSellByDateHasNotPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 1, Quality = 10 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(9, items[0].Quality);
        }

        [Test]
        public void DegradeQualityTwiceAsFastWhenSellByDateHasPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(8, items[0].Quality);
        }

        [Test]
        public void NotDegradeQualityPastZero()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ItemName", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void IncreaseAgedBrieQualityByOneWhenSellInDateNotPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(1, items[0].Quality);
        }

        [Test]
        public void IncreaseAgedBrieQualityTwiceAsFastWhenSellInDateHasPassed()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(2, items[0].Quality);
        }

        [Test]
        public void NotIncreaseQualityMoreThan50IfItemIsNotSulfuras()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(50, items[0].Quality);
        }

        [Test]
        public void NotChangeSulfurasHandOfRagnaros()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(1, items[0].SellIn);
        }

        [Test]
        public void IncreaseQualityBy3WhenSellByDateIs5DaysOrLessForBackstagePass()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 0 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(3, items[0].Quality);
        }

        [Test]
        public void IncreaseQualityBy2WhenSellByDateIs10DaysOrLessForBackstagePass()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 0 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(2, items[0].Quality);
        }

        [Test]
        public void IncreaseQualityBy1WhenSellByDateIs11DaysOrMoreForBackstagePass()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 0 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(1, items[0].Quality);
        }

        [Test]
        public void DropQualityToZeroWhenSellByDateIsPassedForBackstagePass()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 } };
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.UpdateItems();
            Assert.AreEqual(0, items[0].Quality);
        }

    }
}
