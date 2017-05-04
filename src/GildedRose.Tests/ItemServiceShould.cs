using Xunit;
using GildedRose.Console;
using Shouldly;

namespace GildedRose.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    

    public class ItemServiceShould
    {
        private IList<ItemModel> Items;
        public ItemServiceShould()
        {
            Items = new List<ItemModel>
            {
                new ItemModel {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new ItemModel {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new ItemModel {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new ItemModel
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new ItemModel {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }

        [Fact]
        public void Harness()
        {
            var service = new ItemService(Items);
            service.UpdateQuality();
            int expectedQualityOfSulfuras = 80;
            var expectedItems = new List<ItemModel>
            {
                new ItemModel {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new ItemModel {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new ItemModel {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = expectedQualityOfSulfuras},
                new ItemModel
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 14,
                    Quality = 21
                },
                new ItemModel {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
            };

            int index = 0;

            var sulfuras = Items.First(x => x.Name.Equals("Sulfuras, Hand of Ragnaros"));
            sulfuras.Quality.ShouldBe(expectedQualityOfSulfuras);

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