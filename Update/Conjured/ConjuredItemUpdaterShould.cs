using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace csharp.Update.Conjured
{
    [TestFixture]
    public class ConjuredItemUpdaterShould
    {
        [Test]
        public void DegradeQualityByFourWhenSellInDateHasPassed()
        {
            var conjuredItem = new Item
            {
                Name = ItemName.ConjuredManaCake,
                Quality = 10,
                SellIn = 0
            };

            var conjuredItemUpdater = new ConjuredItemUpdater();
            conjuredItemUpdater.Update(conjuredItem);

            Assert.AreEqual(6, conjuredItem.Quality);
        }

        [Test]
        public void DegradeQualityByTwoWhenSellInDateNotPassed()
        {
            var conjuredItem = new Item
            {
                Name = ItemName.ConjuredManaCake,
                Quality = 10,
                SellIn = 1
            };

            var conjuredItemUpdater = new ConjuredItemUpdater();
            conjuredItemUpdater.Update(conjuredItem);

            Assert.AreEqual(8, conjuredItem.Quality);
        }
    }
}
