using GildedRose.Console;
using Shouldly;
using Xunit;

namespace GildedRose.Tests
{
    public class RegularItemShould
    {
        const int MAX_QUALITY = 50;
        const int MIN_QUALITY = 0;

        [Fact]
        public void Never_Have_Quality_Bigger_Than_Fifty()
        {
            var item = new RegularItem();

            int actualQuality = 51;
            item.Quality = actualQuality;
            item.Quality.ShouldBe(MAX_QUALITY);
        }

        [Fact]
        public void Never_Have_Quality_Less_Than_Zero()
        {
            var item = new RegularItem();

            int actualQuality = -1;
            item.Quality = actualQuality;
            item.Quality.ShouldBe(MIN_QUALITY);
        }

        [Fact]
        public void Have_Quality_BETWEEN_ZERO_AND_FIFITY()
        {
            var item = new RegularItem();

            int actualQuality = 1;
            item.Quality = actualQuality;
            item.Quality.ShouldBe(actualQuality);
        }

        [Fact]
        public void Update_Quality()
        {
            var item = new RegularItem();

            int actualQuality = 1;
            item.Quality = actualQuality;
            item.Quality++;
            int expectedQuality = 2;

            item.Quality.ShouldBe(expectedQuality);
        }
    }
}
