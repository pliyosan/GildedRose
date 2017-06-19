﻿using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ItemFactoryShould
    {

        [Theory]
        [InlineData("Sulfuras, Hand of Ragnaros")]
        public void CreateLegendaryItem(string name)
        {
            var sut = new ItemFactory();

            var response = sut.CreateItem(new Item() {Name = name});

            Assert.IsType<LegendaryRegularItem>(response);
        }
    }
}
