using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class Context:DbContext
    {
        public Context():base("Data Source=.;Initial Catalog=DB_Stock_Managment;Integrated Security=True")
        {

        }
        public DbSet<Stock> Stocks { get; set; } 
        public DbSet<Category> Categories{ get; set; } 
        public DbSet<Item> Items{ get; set; }
        public DbSet<ItemInStock> ItemInStocks{ get; set; }
        
    }
}
