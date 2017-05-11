using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{

    public static class ListItemExtension
    {
        public static IList<ItemModel> ToItemsModel(this IList<Item> items)
        {

            return items.Select(i => new ItemModel
            {
                Name = i.Name,
                Quality = i.Quality,
                SellIn = i.SellIn
            }).ToList();
        }
    }


    public class ItemService
    {
        private IList<ItemModel> _items;

        public ItemService(IList<ItemModel> items)
        {
            _items = items;
        }
        public ItemService(IList<Item> items)
        {
            _items = items.ToItemsModel();
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
