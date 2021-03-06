using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class Stock
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<ItemInStock> ItemInStocks { get; set; }
        public virtual List<ImportItem> ImportItems { get; set; }
        public virtual List<ExportItem> ExportItems { get; set; }



    }
}
