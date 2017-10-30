using NUnit.Framework;

namespace csharp.Update.Sulfuras
{
    [TestFixture]
    public class SulfurasItemUpdaterShould
    {
        private SulfurasItemUpdater _sulfurasItemUpdater;

        [SetUp]
        public void SetUp()
        {
            _sulfurasItemUpdater = new SulfurasItemUpdater();
        }

        [Test]
        public void NotChangeItem()
        {
            var item = new Item {Name = SpecialItemNames.Sulfuras, SellIn = 1, Quality = 80};
            _sulfurasItemUpdater.Update(item);
            Assert.AreEqual(80, item.Quality);
            Assert.AreEqual(1, item.SellIn);
        }
    }
}
