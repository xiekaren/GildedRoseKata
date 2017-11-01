namespace csharp
{
    public class ItemUpdaterFactory
    {
        public ItemUpdater GetUpdaterFor(Item item)
        {
            if (item.Name == ItemName.Sulfuras)
            {
                return new SulfurasItemUpdater();
            }
            if (item.Name == ItemName.AgedBrie)
            {
                return new AgedBrieItemUpdater();
            }
            if (item.Name == ItemName.BackstagePasses)
            {
                return new BackstagePassesItemUpdater();
            }
            if (item.Name == ItemName.ConjuredManaCake)
            {
                return new ConjuredItemUpdater();;
            }
            return new DefaultItemUpdater();
        }
    }
}
