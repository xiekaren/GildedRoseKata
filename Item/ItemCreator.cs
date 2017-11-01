using System.Collections.Generic;

namespace csharp
{
    public class ItemCreator
    {
        public IList<Item> Create()
        {
            return new List<Item> {
                new Item {Name = ItemName.DexterityVest, SellIn = 10, Quality = 20},
                new Item {Name = ItemName.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = ItemName.ElixirOfMongoose, SellIn = 5, Quality = 7},
                new Item {Name = ItemName.Sulfuras, SellIn = 0, Quality = 80},
                new Item {Name = ItemName.Sulfuras, SellIn = -1, Quality = 80},
                new Item {Name = ItemName.BackstagePasses, SellIn = 15, Quality = 20},
                new Item {Name = ItemName.BackstagePasses, SellIn = 10, Quality = 49},
                new Item {Name = ItemName.BackstagePasses, SellIn = 5, Quality = 49},
                new Item {Name = ItemName.ConjuredManaCake, SellIn = 3, Quality = 10}
            };
        }
    }
}
