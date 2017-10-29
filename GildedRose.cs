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

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateQuality(item);
            }
        }

        private void UpdateQuality(Item item)
        {
            switch (item.Name)
            {
                case Sulfuras:
                    return;
                case AgedBrie:
                    UpdateItem(item, new AgedBrieItemUpdater());
                    return;
                case BackstagePasses:
                    UpdateItem(item, new BackstagePassesItemUpdater());
                    return;
                default:
                    UpdateItem(item, new DefaultItemUpdater());
                    return;
            }
        }

        private void UpdateItem(Item item, ItemUpdater updater)
        {
            updater.Update(item);
        }    
    }
}
