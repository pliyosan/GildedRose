namespace GildedRose.Console
{
    public class LegendaryItem : ItemModel
    {
        private const int CONSTANT_QUALITY = 80;

        public override int Quality
        {
            get
            {
                return CONSTANT_QUALITY;
            }
        }
    }
}