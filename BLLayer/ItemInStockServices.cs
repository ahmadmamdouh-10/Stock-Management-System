using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLayer
{
    public class ItemInStockServices
    {
        Context Context;
        public ItemInStockServices()
        {
            Context = new Context();
        }
        public void AddItemInStock(ItemInStock itemInStock)
        {
            this.Context.ItemInStocks.Add(itemInStock);
            this.Context.SaveChanges();
        }
        public void EditItemInStock(int iteminstock_id, int quantity, DateTime date)
        {
            this.Context.ItemInStocks.Where(it => it.ID == iteminstock_id).First().Quantity = quantity;
            this.Context.ItemInStocks.Where(it => it.ID == iteminstock_id).First().Date = date;
            this.Context.SaveChanges();
        }
        public void DeleteItemInStock(int iteminstock_id)
        {
            ItemInStock itemInStock = this.Context.ItemInStocks.Where(it => it.ID == iteminstock_id).First();
            this.Context.ItemInStocks.Remove(itemInStock);
            this.Context.SaveChanges();
        }
        public int GetItemInStockID(int stock_id, int item_id)
        {
            return this.Context.ItemInStocks.Where(it => it.Stock_ID == stock_id
            && it.Item_ID == item_id
            ).First().ID;
        }
        public dynamic GetAllItemInStock(int? stock_id, string status)
        {
            return (from s in this.Context.Stocks
                    join ins in this.Context.ItemInStocks
                    on s.ID equals ins.Stock_ID
                    join i in this.Context.Items
                    on ins.Item_ID equals i.ID
                    join c in this.Context.Categories
                    on i.Cat_ID equals c.ID
                    where s.ID == stock_id && ins.Status == status
                    select new
                    {
                        ID = ins.ID,
                        Item_id = i.ID,
                        Item = i.Name,
                        Category = c.Name,
                        Qunatity = ins.Quantity,
                        Date = ins.Date
                    }).ToList();
        }
        public List<Item> GetAllItemInStock(int? stock_id)
        {
            return (from s in this.Context.Stocks
                    join ins in this.Context.ItemInStocks
                    on s.ID equals ins.Stock_ID
                    join i in this.Context.Items
                    on ins.Item_ID equals i.ID
                    join c in this.Context.Categories
                    on i.Cat_ID equals c.ID
                    where s.ID == stock_id 
                    select i).Distinct().ToList();
        }
    }
}
