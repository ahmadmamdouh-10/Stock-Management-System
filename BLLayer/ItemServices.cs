using DBLayer;
using System.Collections.Generic;
using System.Linq;
namespace BLLayer
{
    public class ItemServices
    {
        private readonly Context Context;

        public ItemServices(Context Context)
        {
            this.Context = Context;
        }
        public int AddItem(Item item)
        {
            Item Item = Context.Items.Where(I => I.Name == item.Name && I.Cat_ID == item.Cat_ID).FirstOrDefault();
            if (Item == null)
            {
                this.Context.Items.Add(item);
                return this.Context.SaveChanges();
            }

            return 0;

        }
        public void EditItem(int item_id, string name)
        {
            this.Context.Items.Where(i => i.ID == item_id).First().Name = name;
            this.Context.SaveChanges();
        }
        public void EditItem(int item_id, int cat_id)
        {
            this.Context.Items.Where(i => i.ID == item_id).First().Cat_ID = cat_id;
            this.Context.SaveChanges();
        }
        public void DeleteItem(int item_id)
        {
            Item item = this.Context.Items.Where(i => i.ID == item_id).First();
            this.Context.Items.Remove(item);
            this.Context.SaveChanges();
        }
        public List<Item> GetAllItemsByCatID(int? cat_id)
        {
            return this.Context.Items.Where(i => i.Cat_ID == cat_id).ToList();
        }
        public int GetCatID(int item_id)
        {
            return this.Context.Items.Where(i => i.ID == item_id).First().Cat_ID;
        }
        public int GetQuantity(int? item_id, int? stock_id)
        {
            var itemInStock = Context.ItemInStocks.FirstOrDefault(I => I.Stock_ID == stock_id && I.Item_ID == item_id);
            if (itemInStock != null)
            {
                return itemInStock.OverAllQuantity;
            }
            return 0;

        }
        public List<Item> GetAllItemsByCatIDandStockID(int? cat_id, int? stock_id)
        {
            return (from s in this.Context.Stocks
                    join ins in this.Context.ItemInStocks
                    on s.ID equals ins.Stock_ID
                    join it in this.Context.Items
                    on ins.Item_ID equals it.ID
                    join c in this.Context.Categories
                    on it.Cat_ID equals c.ID
                    where s.ID == stock_id && c.ID == cat_id
                    select it).Distinct().ToList();
        }
    }
}
