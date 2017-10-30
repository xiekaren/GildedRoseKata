using System.Collections.Generic;
using NUnit.Framework;

namespace csharp.Update.Default
{
    [TestFixture]
    public class DefaultUpdaterShould
    {
        private DefaultItemUpdater _defaultItemUpdater;

        [SetUp]
        public void SetUp()
        {
            _defaultItemUpdater = new DefaultItemUpdater();
        }

        [Test]
        public void DegradeQualityByOneWhenSellByDateHasNotPassed()
        {
            var item = new Item { Name = "SomeItem", SellIn = 1, Quality = 10 };
            _defaultItemUpdater.Update(item);
            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void DegradeQualityTwiceAsFastWhenSellByDateHasPassed()
        {
            var item = new Item { Name = "SomeItem", SellIn = 0, Quality = 10 };
            _defaultItemUpdater.Update(item);
            Assert.AreEqual(8, item.Quality);
        }

        [Test]
        public void NotDegradeQualityPastZero()
        {
            var item = new Item { Name = "SomeItem", SellIn = 0, Quality = 0 };
            _defaultItemUpdater.Update(item);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
