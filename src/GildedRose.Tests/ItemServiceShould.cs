using Xunit;

namespace GildedRose.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using GildedRose.Console;

    public class ItemServiceShould
    {
        private IList<Item> Items;
        public ItemServiceShould()
        {
            Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }

        [Fact]
        public void Harness()
        {
            var service = new ItemService(Items);
            service.UpdateQuality();
            var expectedItems = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 14,
                    Quality = 21
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
            };

            int index = 0;
            foreach (var value in Items)
            {
                Assert.Equal(value.Name, expectedItems[index].Name);
                Assert.Equal(value.Quality, expectedItems[index].Quality);
                Assert.Equal(value.SellIn, expectedItems[index].SellIn);
                index++;
            }
        }
    }
}