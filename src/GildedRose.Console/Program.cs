using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
            var factory = new ItemFactory();

            var Items = new List<Item>
            {
                factory.CreateItem(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}),
                factory.CreateItem(new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}),
                factory.CreateItem(new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}),
                factory.CreateItem(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}),
                factory.CreateItem(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }),
                factory.CreateItem(new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6})
            };

            var app = new ItemService(Items);

            app.UpdateQuality();

            System.Console.ReadKey();
        }
    }
}
