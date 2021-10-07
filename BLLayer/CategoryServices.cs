using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLayer
{
    public class CategoryServices
    {
        Context Context;
        public CategoryServices()
        {
            Context = new Context();
        }
        public List<Category> GetAllCategories()
        {
            return this.Context.Categories.ToList();
        }
        public void AddCategory(Category category)
        {
            this.Context.Categories.Add(category);
            this.Context.SaveChanges();
        }
        public void EditCategory(int cat_id, string name)
        {
            this.Context.Categories.Where(c => c.ID == cat_id).First().Name = name;
            this.Context.SaveChanges();
        }
        public void DeleteCategory(int cat_id)
        {
            Category category  = this.Context.Categories.Where(c => c.ID == cat_id).First();
            this.Context.Categories.Remove(category);
            this.Context.SaveChanges();
        }

        public List<Category> GetAllCatByStockID(int? stock_id , string status)
        {
            return (from s in Context.Stocks
                    join ins in this.Context.ItemInStocks
                    on s.ID equals ins.Stock_ID
                    join i in Context.Items
                    on ins.Item_ID equals i.ID
                    join c in Context.Categories
                    on i.Cat_ID equals c.ID
                    where s.ID == stock_id && ins.Status==status
                    select c).ToList();
        }
    }
}
