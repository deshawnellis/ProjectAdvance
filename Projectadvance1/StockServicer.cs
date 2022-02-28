using System;
namespace Projectadvance1.Models
{
    public class StockServicer
    {
        public StockServicer()
        {
        }


        public bool IsStockMarketOpen()
        {
            if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 16 )
                return true;

            else
                return false;
        }


        //TODO: Create any kind of method that returns anything
    }
}
