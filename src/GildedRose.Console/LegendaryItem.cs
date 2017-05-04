namespace GildedRose.Console
{
    public class LegendaryItem : ItemModel
    {
        private const int MAX_VALUE = 80;
        private int _quality = 0;

        public override int Quality
        {
            get
            {
                return _quality;
            }
            set
            {
                if (Name == "Sulfuras, Hand of Ragnaros")
                    _quality = MAX_VALUE;
            }
        }
    }
}