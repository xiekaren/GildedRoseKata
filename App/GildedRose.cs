using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly ItemUpdaterFactory _itemUpdaterFactory;
        private readonly ItemCreator _itemCreator;

        public GildedRose(ItemCreator itemCreator, ItemUpdaterFactory itemUpdaterFactory)
        {
            _itemCreator = itemCreator;
            _itemUpdaterFactory = itemUpdaterFactory;
        }

        public void RunFor(int days)
        {
            var items = _itemCreator.Create();

            for (var day = 0; day <= days; day++)
            {
                PrintHeader(day);
                PrintItemProperties(items);
                Console.WriteLine("");
                Update(items);
            }
        }

        private void Update(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                var itemUpdater = _itemUpdaterFactory.GetUpdaterFor(item);
                itemUpdater.Update(item);
            }
        }

        private void PrintItemProperties(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            }
        }

        private void PrintHeader(int day)
        {
            Console.WriteLine("-------- day " + day + " --------");
            Console.WriteLine("name, sellIn, quality");
        }
    }
}
