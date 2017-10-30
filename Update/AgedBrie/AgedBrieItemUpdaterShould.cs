using System.Collections.Generic;
using NUnit.Framework;

namespace csharp.Update.AgedBrie
{
    [TestFixture]
    public class AgedBrieItemUpdaterShould
    {
        private AgedBrieItemUpdater _agedBrieItemUpdater;

        [SetUp]
        public void SetUp()
        {
            _agedBrieItemUpdater = new AgedBrieItemUpdater();
        }

        [Test]
        public void IncreaseAgedBrieQualityByOneWhenSellInDateNotPassed()
        {
            var item = new Item {Name = "Aged Brie", SellIn = 1, Quality = 0};
            _agedBrieItemUpdater.Update(item);
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void IncreaseAgedBrieQualityTwiceAsFastWhenSellInDateHasPassed()
        {
            var item = new Item {Name = "Aged Brie", SellIn = 0, Quality = 0};
            _agedBrieItemUpdater.Update(item);
            Assert.AreEqual(2, item.Quality);
        }

        [Test]
        public void NotIncreaseQualityMoreThan50()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 };
            _agedBrieItemUpdater.Update(item);
            Assert.AreEqual(50, item.Quality);
        }
    }
}
