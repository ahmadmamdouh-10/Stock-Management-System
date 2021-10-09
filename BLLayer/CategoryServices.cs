using DBLayer;
using System.Collections.Generic;
using System.Linq;

namespace BLLayer
{
    public class CategoryServices
    {
        private readonly Context Context;

        public CategoryServices(Context Context)
        {
            this.Context = Context;
        }
        public List<Category> GetAllCategories()
        {
            return this.Context.Categories.ToList();
        }
        public int AddCategory(Category category)
        {
            Category Category = Context.Categories.Where(C => C.Name == category.Name).FirstOrDefault();
            if(Category==null)
            {
                this.Context.Categories.Add(category);
                return this.Context.SaveChanges();
            }
            return 0;
          
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
        public List<Category> GetAllCatByStockID(int? stock_id)
        {
           return Context.ItemInStocks.Where(In => In.Stock_ID == stock_id).Select(In => In.Item.Category).ToList();
        }
    }
}
