using Xunit;
using GildedRose.Console;
using Shouldly;

namespace GildedRose.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    

    public class HarnessShould
    {
        private IList<Item> Items;
        public HarnessShould()
        {
            var itemFactory = new ItemFactory();
            Items = new List<Item>
            {
                itemFactory.CreateItem(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}),
                itemFactory.CreateItem(new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}),
                itemFactory.CreateItem(new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}),
                itemFactory.CreateItem(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}),
                itemFactory.CreateItem(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }),
                itemFactory.CreateItem(new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6})
            };
        }

        [Fact]
        public void Harness()
        {
           var Items = new List<Item>
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
            var service = new ItemService(Items);
            service.UpdateQuality();
            int expectedQualityOfSulfuras = 80;
            var expectedItems = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = expectedQualityOfSulfuras},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 14,
                    Quality = 21
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
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

        [Fact]
        public void HarnessScafoldingQuestionMark()
        {
            var service = new ItemService(Items);
            service.UpdateQuality();
            int expectedQualityOfSulfuras = 80;
            var expectedItems = new List<Item>
            {
                new RegularItem {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new RegularItem {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new RegularItem {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = expectedQualityOfSulfuras},
                new BackStagePassesItem()
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 14,
                    Quality = 21
                },
                new RegularItem {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
            };

            int index = 0;

            var sulfuras = Items.First(x => x.Name.Equals("Sulfuras, Hand of Ragnaros"));
            sulfuras.Quality.ShouldBe(expectedQualityOfSulfuras);

            foreach (var value in Items)
            {
                Assert.Equal(expectedItems[index].Name, value.Name);
                Assert.Equal(expectedItems[index].Quality, value.Quality);
                Assert.Equal(expectedItems[index].SellIn, value.SellIn);
                index++;
            }
        }
    }
}