using System;
using Projectadvance1.Models;

namespace Projectadvance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // https://github.com/deshawnellis/ProjectAdvance.git


            //Several Types of Projects

            //Console App
            //Runs functions and opertaions without any graphic interface
            //ex: Calculating stock pricing, gather user info, stores items in the database

            //Web App   
            //A application on the web that allows global access to perform actions on web pages
            //ex. An online portal that users can see how there stock knowledge is doing

            //Web Api
            //Application program interface that allows communication between different platforms (web, mobile, devices, tv, etc.)
            //ex. gather information from several sources such as iex and combines that info to send to different platforms

            //Mobile App
            //An application on a mobile device that perform various actions
            //Phone app that has all this information



            //Object Orient Programming
            //Classes,

            //Initate by calling a new object

            var myStock = new Stock("Apple");
            //myStock.CompanyName = "Apple";

            //TODO: Set additional Properties


            //Get DateTime
            var today = DateTime.Now;
            Console.WriteLine(today);

            //
            //methods, interfaces  

            //Method Example
            Console.WriteLine(CalculateFee());





            #region Using Strings

            //Strings:
            //And words, letters, values in quotation - basically text for the system

            var name = "Kweku Martin";
            name = "Mr. Ellis";

            var number = 5;
            Console.WriteLine(number.ToString());


            //TODO: Create 10 new string values;


            #endregion



            #region Working With Methods

            //A method is a function that executes a seperate block of code


            var firstName = "Michael";
            var lastName = "Jones";

            var fullName = CreateFullName(firstName, lastName);
            Console.WriteLine(fullName);

            var service = new StockServicer();


            if(service.IsStockMarketOpen() == false)
            {
                Console.WriteLine("WERE CLOSED!!!!");
            }


            #endregion


            #region Value Types

            var Apple = StockType.BlueChip;


            #endregion

        }

        private static string CreateFullName(string firstName, string lastName = null)
        {
            //TODO: Add a new parameter for middle name and add it to the return value

            return firstName + ' ' + lastName;
        }

        private static void InformUser()
        {
            //void means no return is necessary

            Console.WriteLine("Empty Method");
        }

        public static float CalculateFee()
        {
            return 5;
        }

        public enum StockType
        {
            BlueChip,
            Penny,
            Faang
        }
    }
}
