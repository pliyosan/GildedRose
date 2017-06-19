﻿namespace GildedRose.Console
{
    public class RegularItem : Item
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 50;
        private int _quality = 0;

        public override string Name { get; set; }

        public override int SellIn { get; set; }

        public override int Quality
        {
            get { return _quality; }
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
