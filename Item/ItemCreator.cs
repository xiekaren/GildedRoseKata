using System.Collections.Generic;

namespace csharp
{
    public class ItemCreator
    {
        public IList<Item> Create()
        {
            return new List<Item> {
                new Item {Name = ItemNames.DexterityVest, SellIn = 10, Quality = 20},
                new Item {Name = ItemNames.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = ItemNames.ElixirOfMongoose, SellIn = 5, Quality = 7},
                new Item {Name = ItemNames.Sulfuras, SellIn = 0, Quality = 80},
                new Item {Name = ItemNames.Sulfuras, SellIn = -1, Quality = 80},
                new Item {Name = ItemNames.BackstagePasses, SellIn = 15, Quality = 20},
                new Item {Name = ItemNames.BackstagePasses, SellIn = 10, Quality = 49},
                new Item {Name = ItemNames.BackstagePasses, SellIn = 5, Quality = 49},
                // TODO: this conjured item does not work properly yet
                new Item {Name = ItemNames.ConjuredManaCake, SellIn = 3, Quality = 6}
            };
        }
    }
}
