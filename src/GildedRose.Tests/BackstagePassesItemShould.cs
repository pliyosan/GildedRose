using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using GildedRose.Console;
using Shouldly;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassesItemShould
    {
        [Theory]
        [InlineData(9, 1, 3)]
        [InlineData(9, 2, 4)]
        public void Increase_Quality_By_Two_When_Less_Than_TenDays_OfSellin(int sellIn, int quality, int expectedQuality)
        {
            var backStage = new BackStagePassesItem();
            backStage.SellIn = sellIn;
            backStage.Quality = quality;

            backStage.UpdateQuality();

            backStage.Quality.ShouldBe(expectedQuality);
        }

        [Theory]
        [InlineData(4, 1, 4)]
        [InlineData(4, 2, 5)]
        public void Increase_Quality_By_Three_When_Less_Than_FiveDays_OfSellin(int sellIn, int quality, int expectedQuality)
        {
            var backStage = new BackStagePassesItem();
            backStage.SellIn = sellIn;
            backStage.Quality = quality;

            backStage.UpdateQuality();

            backStage.Quality.ShouldBe(expectedQuality);
        }

        [Theory]
        [InlineData(0, 12, 0)]
        [InlineData(0, 7, 0)]
        public void Drop_Quality_To_Zero_After_Concert(int sellIn, int quality, int expectedQuality)
        {
            var backStage = new BackStagePassesItem();
            backStage.SellIn = sellIn;
            backStage.Quality = quality;

            backStage.UpdateQuality();

            backStage.Quality.ShouldBe(expectedQuality);
        }
        [Theory]
        [InlineData(9, 1, 8)]
        [InlineData(4, 2, 3)]
        public void Decrease_Selling_By_One(int sellIn, int quality, int expectedQuality)
        {
            var backStage = new BackStagePassesItem();
            backStage.SellIn = sellIn;
            backStage.Quality = quality;

            backStage.UpdateQuality();

            backStage.SellIn.ShouldBe(expectedQuality);
        }
    }
}
