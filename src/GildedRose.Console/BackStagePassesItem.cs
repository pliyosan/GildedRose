namespace GildedRose.Console
{
    public class BackStagePassesItem : Item
    {
        public override void UpdateQuality()
        {
            if (SellIn <= 0)
                Quality = 0;
            else if (SellIn <= 5)
                Quality = Quality + 3;
            else if (SellIn <= 10)
                Quality = Quality + 2;
            else
                Quality = Quality + 1;

            SellIn = SellIn - 1;
        }
    }
}