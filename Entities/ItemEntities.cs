using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlData;
using Model;
using System.Data;
namespace Entities
{
    public class ItemEntities
    {
        public ItemSqlData itemSql { get; set; }

        public ItemEntities()
        {
            itemSql = new ItemSqlData();
        }

        public List<Item> GetItemsEntities()
        {
            return convertToItem(itemSql.GetItemsSql());
        }
        public List<Item> GetItemsSumEntities()
        {
            return convertToItem(itemSql.GetItemsSumSql());
        }
        public List<Item> convertToItem(DataTable dtbl)
        {
            List<Item> items = new List<Item>();
            if (dtbl.Rows.Count > 0)
            {
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    Item item = new Item();
                    item.name = dtbl.Rows[i]["typeName"].ToString();
                    item.amount = Convert.ToInt32(dtbl.Rows[i]["amount"]);
                    items.Add(item);
                }
            }
            return items;

        }
    }
}
