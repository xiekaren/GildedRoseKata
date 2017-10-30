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

        public void Run(int days)
        {
            for (var i = 0; i <= days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in _items)
                {
                    Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
                }
                Console.WriteLine("");
                UpdateItems();
            }
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
