using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public abstract class ItemUpdater
    {
        private const int MaxItemQuality = 50;
        private const int MinItemQuality = 0;

        public abstract void Update(Item item);

        protected int IncreaseQuality(Item item, int amount)
        {
            return Math.Min(MaxItemQuality, item.Quality + amount);
        }

        protected int DecreaseQuality(Item item, int amount)
        {
            return Math.Max(MinItemQuality, item.Quality - amount);
        }
    }

    public class AgedBrieUpdater : ItemUpdater
    {
        public override void Update(Item item)
        {
            item.SellIn = item.SellIn - 1;
            var updateAmount = item.SellIn >= 0 ? 1 : 2;
            item.Quality = IncreaseQuality(item, updateAmount);
        }
    }
}
