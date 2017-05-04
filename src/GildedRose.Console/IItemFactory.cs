using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class ItemFactory
    {
        public ItemModel CreateItem(string name)
        {
            switch (name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItem();

                default:
                    return new ItemModel();
            }
        }

    }
}
