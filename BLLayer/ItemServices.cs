using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
/// <summary>
/// test first push 
/// </summary>
namespace BLLayer
{
    public class ItemServices
    {
        Context Context;
        public ItemServices()
        {
            Context = new Context();
        }
        public void AddItem(Item item)
        {
            this.Context.Items.Add(item);
            this.Context.SaveChanges();
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
            return this.Context.Items.Where(i=>i.Cat_ID == cat_id).ToList();
        }

        public int GetCatID(int item_id)
        {
            return this.Context.Items.Where(i => i.ID == item_id).First().Cat_ID;
        }
        public int GetQuantity(int? item_id , int? stock_id)
        {
            if (item_id == null)
                return 0;
            int ImportQunatities = this.Context.ItemInStocks.Where(i => i.Item_ID == item_id && i.Status == "Import" && i.Stock_ID == stock_id).Select(i => i.Quantity).DefaultIfEmpty(0).Sum();
            int ExprotQunatities = this.Context.ItemInStocks.Where(i => i.Item_ID == item_id && i.Status == "Export" && i.Stock_ID == stock_id).Select(i=>i.Quantity).DefaultIfEmpty(0).Sum();
            return ImportQunatities - ExprotQunatities;
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
