using DBLayer;
using System.Collections.Generic;
using System.Linq;

namespace BLLayer
{
    public class StockServices
    {
        private readonly Context Context;

        public StockServices(Context Context)
        {
            this.Context = Context;
        }
        public int AddStock(Stock stock)
        {
            Stock Stock = Context.Stocks.Where(s => s.Name == stock.Name).FirstOrDefault();
            if (Stock == null)
            {
                this.Context.Stocks.Add(stock);
                return this.Context.SaveChanges();
            }

            return 0;

        }
        public void EditStock(int stock_id, string name)
        {
            this.Context.Stocks.Where(s => s.ID == stock_id).First().Name = name;
            this.Context.SaveChanges();
        }
        public void DeleteStock(int stock_id)
        {
            Stock stock = this.Context.Stocks.Where(s => s.ID == stock_id).First();
            this.Context.Stocks.Remove(stock);
            this.Context.SaveChanges();
        }
        public List<Stock> GetStocks()
        {
            return this.Context.Stocks.ToList();
        }
    }
}
