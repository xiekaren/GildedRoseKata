using NUnit.Framework;

namespace csharp.Update.BackstagePasses
{
    [TestFixture]
    public class BackstagePassesItemUpdaterShould
    {
        private BackstagePassesItemUpdater _backstagePassesItemUpdater;

        [SetUp]
        public void SetUp()
        {
            _backstagePassesItemUpdater = new BackstagePassesItemUpdater();
        }

        [Test]
        public void IncreaseQualityBy3WhenSellByDateIs5DaysOrLess()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 0 };
            _backstagePassesItemUpdater.Update(item);
            Assert.AreEqual(3, item.Quality);
        }

        [Test]
        public void IncreaseQualityBy2WhenSellByDateIs10DaysOrLess()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 0 };
            _backstagePassesItemUpdater.Update(item);
            Assert.AreEqual(2, item.Quality);
        }

        [Test]
        public void IncreaseQualityBy1WhenSellByDateIs11DaysOrMore()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 0 };
            _backstagePassesItemUpdater.Update(item);
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void DropQualityToZeroWhenSellByDateIsPassed()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 };
            _backstagePassesItemUpdater.Update(item);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
