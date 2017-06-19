namespace GildedRose.Console
{
    public class ItemFactory
    {
        public Item CreateItem(Item regularItem)
        {
            switch (regularItem.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem()
                    {
                        Name = regularItem.Name,
                        Quality = regularItem.Quality,
                        SellIn = regularItem.SellIn
                    };
                default:
                    return new RegularItem()
                    {
                        Name = regularItem.Name,
                        Quality = regularItem.Quality,
                        SellIn = regularItem.SellIn
                    };
            }
        }

    }
}
