namespace csharp
{
    public class ItemUpdaterFactory
    {
        public ItemUpdater GetUpdaterFor(Item item)
        {
            if (item.Name == SpecialItemNames.Sulfuras)
            {
                return new SulfurasItemUpdater();
            }
            if (item.Name == SpecialItemNames.AgedBrie)
            {
                return new AgedBrieItemUpdater();
            }
            if (item.Name == SpecialItemNames.BackstagePasses)
            {
                return new BackstagePassesItemUpdater();
            }
            return new DefaultItemUpdater();
        }
    }
}
