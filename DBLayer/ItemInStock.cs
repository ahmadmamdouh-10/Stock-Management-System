using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class ItemInStock
    {
        public int ID { get; set; }
        [ForeignKey("Item")]
        public int? Item_ID { get; set; }
        [ForeignKey("Stock")]
        public int? Stock_ID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } // import or export
        public virtual Item Item  { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
