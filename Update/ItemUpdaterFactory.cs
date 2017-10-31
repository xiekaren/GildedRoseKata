namespace csharp
{
    public class ItemUpdaterFactory
    {
        public ItemUpdater GetUpdaterFor(Item item)
        {
            if (item.Name == ItemNames.Sulfuras)
            {
                return new SulfurasItemUpdater();
            }
            if (item.Name == ItemNames.AgedBrie)
            {
                return new AgedBrieItemUpdater();
            }
            if (item.Name == ItemNames.BackstagePasses)
            {
                return new BackstagePassesItemUpdater();
            }
            return new DefaultItemUpdater();
        }
    }
}
