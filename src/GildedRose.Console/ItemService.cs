using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{

    public static class ListItemExtension
    {
        public static IList<RegularItem> ToItemsModel(this IList<RegularItem> items)
        {

            return items.Select(i => new RegularItem
            {
                Name = i.Name,
                Quality = i.Quality,
                SellIn = i.SellIn
            }).ToList();
        }
    }


    public class ItemService
    {
        private IList<Item> _items;

        public ItemService(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < _items.Count; i++)
            {
                _items[i].UpdateQuality();
            }
        }
    }
}
