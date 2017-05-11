namespace GildedRose.Console
{
    public class ItemModel
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 50;
        private int _quality = 0;

        public string Name { get; set; }

        public int SellIn { get; set; }

        public virtual int Quality
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

        public virtual void UpdateQuality()
        {
            if (Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Quality > 0)
                {
                    if (Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Quality = Quality - 1;
                    }
                }
            }
            else
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;

                    if (Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (SellIn < 11)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }

                        if (SellIn < 6)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }
                    }
                }
            }

            if (Name != "Sulfuras, Hand of Ragnaros")
            {
                SellIn = SellIn - 1;
            }

            if (SellIn < 0)
            {
                if (Name != "Aged Brie")
                {
                    if (Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Quality > 0)
                        {
                            if (Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Quality = Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Quality = Quality - Quality;
                    }
                }
                else
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }
            }
        }
    }

}
