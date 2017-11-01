using System;

namespace csharp
{
    public class ConjuredItemUpdater : ItemUpdater
    {
        public override void Update(Item item)
        {
            item.SellIn -= 1;
            var updateAmount = item.SellIn >= 0 ? 2 : 4;
            item.Quality = DecreaseQuality(item, updateAmount);
        }
    }
}