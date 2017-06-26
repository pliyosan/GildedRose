using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ItemFactoryShould
    {

        [Theory]
        [InlineData("Sulfuras, Hand of Ragnaros")]
        public void CreateLegendaryItem(string name)
        {
            int quality = 90;
            var sut = new ItemFactory();

            var response = sut.CreateItem(new Item() {Name = name, Quality = quality});

            Assert.IsType<LegendaryItem>(response);
        }

        [Theory]
        [InlineData("Sulfuras, Hand of Ragnaros", 80, 50)]
        [InlineData("XYZ", 10,10)]
        public void CreateItemWithGivenName(string name, int quality,int sellIn)
        {
            var sut = new ItemFactory();

            var response = sut.CreateItem(new Item()
            {
                Name = name,
                Quality = quality,
                SellIn = sellIn
            });

            Assert.Equal(name, response.Name);
            Assert.Equal(quality, response.Quality);
            Assert.Equal(sellIn, response.SellIn);
        }

        [Theory]
        [InlineData("Backstage passes for U2", 80, 50)]
        public void CreateBackStageItem(string name, int quality, int sellIn)
        {
            var sut = new ItemFactory();

            var response = sut.CreateItem(new Item()
            {
                Name = name,
                Quality = quality,
                SellIn = sellIn
            });

            Assert.Equal(name, response.Name);
            Assert.Equal(quality, response.Quality);
            Assert.Equal(sellIn, response.SellIn);
            Assert.IsType<BackStagePassesItem>(response);
        }

    }
}
