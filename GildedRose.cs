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

            if (item.Name == AgedBrie)
            {
                UpdateAgedBrie(item);
                return;
            }

            if (item.Name == BackstagePasses)
            {
                UpdateBackstagePasses(item);
                return;
            }

            item.Quality = DecreaseQualityByAmount(item, 1);

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
               item.Quality = DecreaseQualityByAmount(item, 1);
            }
        }

        private void UpdateAgedBrie(Item agedBrie)
        {
            agedBrie.SellIn = agedBrie.SellIn - 1;

            if (agedBrie.SellIn >= 0)
            {
                agedBrie.Quality = IncreaseQualityByAmount(agedBrie, 1);
            }
            else
            {
                agedBrie.Quality = IncreaseQualityByAmount(agedBrie, 2);
            }
        }

        private void UpdateBackstagePasses(Item backstagePasses)
        {
            if (backstagePasses.SellIn < 6)
            {
                backstagePasses.Quality = IncreaseQualityByAmount(backstagePasses, 3);
            }
            else if (backstagePasses.SellIn < 11)
            {
                backstagePasses.Quality = IncreaseQualityByAmount(backstagePasses, 2);
            }
            else if (backstagePasses.SellIn >= 11)
            {
                backstagePasses.Quality = IncreaseQualityByAmount(backstagePasses, 1);
            }

            backstagePasses.SellIn = backstagePasses.SellIn - 1;

            if (backstagePasses.SellIn < 0)
            {
                backstagePasses.Quality = DecreaseQualityByAmount(backstagePasses, backstagePasses.Quality);
            }
        }

        private int IncreaseQualityByAmount(Item item, int amount)
        {
            return Math.Min(MaxItemQuality, item.Quality + amount);
        }

        private int DecreaseQualityByAmount(Item item, int amount)
        {
            return Math.Max(MinItemQuality, item.Quality - amount);
        }

    }
}
