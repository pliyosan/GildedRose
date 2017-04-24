namespace GildedRose.Console
{
    public class ItemModel
    {
        //    public string Name { get; set; }

        //    public int SellIn { get; set; }

        //    public int Quality { get; set; }
        //}

        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 50;

        private int _quality = 0;

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality
        {
            get
            {
                return _quality;
            }
            set
            {
                if (value > MAX_VALUE)
                    _quality = MAX_VALUE;
                else if (value < MIN_VALUE)
                    _quality = MIN_VALUE;
                else
                    _quality = value;
            }
        }
    }
}