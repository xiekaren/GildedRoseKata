namespace csharp
{
    public class DefaultItemUpdater : ItemUpdater
    {
        public override void Update(Item item)
        {
            item.SellIn = item.SellIn - 1;
            var updateAmount = item.SellIn >= 0 ? 1 : 2;
            item.Quality = DecreaseQuality(item, updateAmount);
        }
    }
}