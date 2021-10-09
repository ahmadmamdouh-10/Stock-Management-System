using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBLayer
{
    public class ImportItem
    {
        public int ID { get; set; }
        public int Stock_ID { get; set; }
        public int Item_ID { get; set; }
        public DateTime Date { get; set; } 
        public int quantity { get; set; }

        [ForeignKey("Stock_ID")]
        public virtual Stock Stock { get; set; }

        [ForeignKey("Item_ID")]
        public virtual Item Item { get; set; }
    }
}