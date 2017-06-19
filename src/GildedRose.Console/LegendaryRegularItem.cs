namespace GildedRose.Console
{
    public class LegendaryRegularItem : Item
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