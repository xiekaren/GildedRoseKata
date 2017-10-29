using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";

        private const int MaxItemQuality = 50;
        private const int MinItemQuality = 0;

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }
        //TODO: Extract out degrade rate
        //TODO: Extract out min and max quality

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateQuality(item);
            }
        }

        private void UpdateQuality(Item item)
        {
            if (item.Name == Sulfuras)
            {
                return;
            }

            if (item.Name != AgedBrie && item.Name != BackstagePasses)
            {
                if (item.Quality > MinItemQuality)
                {
                    item.Quality = item.Quality - 1;
                }
            }
            else
            {
                if (item.Quality < MaxItemQuality)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == BackstagePasses)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < MaxItemQuality)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < MaxItemQuality)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Name != AgedBrie)
                {
                    if (item.Name != BackstagePasses)
                    {
                        if (item.Quality > MinItemQuality)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxItemQuality)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

        }
    }
}
