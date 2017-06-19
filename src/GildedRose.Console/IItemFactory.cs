namespace GildedRose.Console
{
    public class ItemFactory
    {
        public Item CreateItem(Item regularItem)
        {
            switch (regularItem.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryRegularItem();

                default:
                    return new RegularItem();
            }
        }

    }
}
