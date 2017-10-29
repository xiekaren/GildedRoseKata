using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        private readonly ItemUpdaterFactory _itemUpdaterFactory;

        public GildedRose(IList<Item> items, ItemUpdaterFactory itemUpdaterFactory)
        {
            _items = items;
            _itemUpdaterFactory = itemUpdaterFactory;
        }

        public void UpdateItems()
        {
            foreach (var item in _items)
            {
                var itemUpdater = _itemUpdaterFactory.GetUpdaterFor(item);
                itemUpdater.Update(item);
            }
        } 
    }
}
