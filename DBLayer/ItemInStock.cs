using System.ComponentModel.DataAnnotations.Schema;

namespace DBLayer
{
    public class ItemInStock
    {
        public int ID { get; set; }
        [ForeignKey("Item")]
        public int? Item_ID { get; set; }
        [ForeignKey("Stock")]
        public int? Stock_ID { get; set; }
        public int OverAllQuantity { get; set; }
        public virtual Item Item  { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
