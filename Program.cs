using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var items = GetItems();
            var app = new GildedRose(items, new ItemUpdaterFactory());
            app.RunFor(30);
        }

        private static IList<Item> GetItems()
        {
            return new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = SpecialItemNames.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = SpecialItemNames.Sulfuras, SellIn = 0, Quality = 80},
                new Item {Name = SpecialItemNames.Sulfuras, SellIn = -1, Quality = 80},
                new Item {Name = SpecialItemNames.BackstagePasses, SellIn = 15, Quality = 20},
                new Item {Name = SpecialItemNames.BackstagePasses, SellIn = 10, Quality = 49},
                new Item {Name = SpecialItemNames.BackstagePasses, SellIn = 5, Quality = 49},
                // this conjured item does not work properly yet
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }
    }
}
