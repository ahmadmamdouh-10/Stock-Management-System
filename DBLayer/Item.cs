using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category")]
        public int Cat_ID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ItemInStock> ItemInStocks { get; set; }
    }
}
