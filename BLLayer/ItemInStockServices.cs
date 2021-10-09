using DBLayer;
using System.Linq;

namespace BLLayer
{
    public class ItemInStockServices
    {
        private readonly Context Context;
        public ItemInStockServices(Context Context)
        {
            this.Context = Context;
        }
        public void AddItemInStock(ItemInStock itemInStock)
        {
            this.Context.ItemInStocks.Add(itemInStock);
            this.Context.SaveChanges();
        }
        public void DeleteItemInStock(int iteminstock_id)
        {
            ItemInStock itemInStock = this.Context.ItemInStocks.Where(it => it.ID == iteminstock_id).First();
            this.Context.ItemInStocks.Remove(itemInStock);
            this.Context.SaveChanges();
        }
        public void ImportItem(ImportItem importItem)
        {
            ItemInStock stockItem = Context.ItemInStocks.FirstOrDefault(s => s.Item_ID == importItem.Item_ID && s.Stock_ID == importItem.Stock_ID);
            if (stockItem == null)
            {
                Context.ItemInStocks.Add(new ItemInStock
                {
                    Stock_ID = importItem.Stock_ID,
                    Item_ID = importItem.Item_ID,
                    OverAllQuantity = importItem.quantity
                });

            }
            else
            {
                stockItem.OverAllQuantity += importItem.quantity;

            }

            Context.ImportItems.Add(importItem);
            Context.SaveChanges();


        }
        public void ExportItem(ExportItem exportItem)
        {

            ItemInStock stockItem = Context.ItemInStocks.FirstOrDefault(s => s.Item_ID == exportItem.Item_ID && s.Stock_ID == exportItem.Stock_ID);

            if (stockItem != null)
            {
                if (stockItem.OverAllQuantity >= exportItem.quantity)
                {
                    stockItem.OverAllQuantity -= exportItem.quantity;
                    Context.ExportItems.Add(exportItem);
                    Context.SaveChanges();
                }

            }
        }
        public dynamic GetImportedItems(int stokID)
        {
            return Context.ImportItems.
                 Where(I => I.Stock_ID == stokID).
                 Select(I => new
                 {
                     ItemName = I.Item.Name,
                     CategoryName = I.Item.Category.Name,
                     Quantity = I.quantity,
                     Date = I.Date
                 }).OrderByDescending(I => I.Date).ToList();
        }
        public dynamic GetExportedItems(int stokID)
        {
            return Context.ExportItems.
                 Where(E => E.Stock_ID == stokID).
                 Select(E => new
                 {
                     ItemName = E.Item.Name,
                     CategoryName = E.Item.Category.Name,
                     Quantity = E.quantity,
                     Date = E.Date
                 }).OrderByDescending(I => I.Date).ToList();
        }
        public dynamic GetReportItems(int StotkID)
        {
            return Context.ItemInStocks.Where(I => I.Stock_ID == StotkID)
                 .Select(I =>
                   new
                   {
                       ItemName = I.Item.Name,
                       Category = I.Item.Category.Name,
                       overAllquantity = I.OverAllQuantity
                   }
                 ).ToList();
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
    }
}
