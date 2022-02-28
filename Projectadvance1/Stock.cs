using System; //additional coding libraries that allow you to use additional functionality in your class
namespace Projectadvance1.Models //the "Section" or library your code is in
{
    public class Stock //Name of the class
    {
        public Stock() //Initiation of the class
        {
        }

        public Stock(string StockName)
        {
            CompanyName = StockName;
        }

        public string CompanyName { get; set; }

        public string TickerName { get; set; }


        //TODO: Add 10 more properties to this class
        //Use int, float, datetime

    }
}
