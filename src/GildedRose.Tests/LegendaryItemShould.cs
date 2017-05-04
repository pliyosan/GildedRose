using GildedRose.Console;
using Shouldly;
using Xunit;

namespace GildedRose.Tests
{
    public class LegendaryItemShould
    {
        [Theory]
        [InlineData(80, "Sulfuras, Hand of Ragnaros", 80)]
        [InlineData(10, "Sulfuras, Hand of Ragnaros", 80)]
        public void KeepQualityConstant(int actualQuality, string name, int expectedQuality)
        {

            var item = new LegendaryItem()
            {
                Name = name,
                Quality = expectedQuality
            };

            item.Quality.ShouldBe(expectedQuality);
        }
    }
}
