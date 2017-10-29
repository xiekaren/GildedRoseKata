namespace csharp
{
    public class BackstagePassesItemUpdater : ItemUpdater
    {
        public override void Update(Item item)
        {
            if (item.SellIn < 6)
            {
                item.Quality = IncreaseQuality(item, 3);
            }
            else if (item.SellIn < 11)
            {
                item.Quality = IncreaseQuality(item, 2);
            }
            else if (item.SellIn >= 11)
            {
                item.Quality = IncreaseQuality(item, 1);
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = DecreaseQuality(item, item.Quality);
            }
        }
    }
}