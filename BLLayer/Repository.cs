using DBLayer;

namespace BLLayer
{
   public static class Repository
    {
       public  static  Context Context=>new Context();
        public static CategoryServices CategoryServices => new CategoryServices(Context);
        public static ItemInStockServices ItemInStockServices => new ItemInStockServices(Context);
        public static ItemServices ItemServices => new ItemServices(Context);
        public static StockServices StockServices => new StockServices(Context);

    }
}
