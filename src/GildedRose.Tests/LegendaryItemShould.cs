using GildedRose.Console;
using Shouldly;
using Xunit;

namespace GildedRose.Tests
{
    public class LegendaryItemShould
    {
        [Theory]
        [InlineData(80, 80)]
        [InlineData(10, 80)]
        public void KeepQualityConstant(int actualQuality, int expectedQuality)
        {
            var item = new LegendaryItem()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = expectedQuality
            };

            item.UpdateQuality();

            item.Quality.ShouldBe(expectedQuality);
        }

        [Theory]
        [InlineData(80, 80)]
        public void Never_Has_To_Be_Sold(int actualSellin, int expectedSellin)
        {
            var item = new LegendaryItem()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                SellIn = actualSellin,
            };

            item.UpdateQuality();

            item.SellIn.ShouldBe(expectedSellin);
        }
    }
}
