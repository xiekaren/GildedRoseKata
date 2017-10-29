namespace csharp
{
    public class ItemUpdaterFactory
    {
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";

        public ItemUpdater GetUpdaterFor(Item item)
        {
            if (item.Name == Sulfuras)
            {
                return new SulfurasItemUpdater();
            }
            if (item.Name == AgedBrie)
            {
                return new AgedBrieItemUpdater();
            }
            if (item.Name == BackstagePasses)
            {
                return new BackstagePassesItemUpdater();
            }
            return new DefaultItemUpdater();
        }
    }
}
