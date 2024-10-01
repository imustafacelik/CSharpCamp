using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write Commands

            //Console.Write("Hello World");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Food Categories *****");
            //Console.WriteLine("");
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Main Foods");
            //Console.WriteLine("3-Cold Starts");
            //Console.WriteLine("4-Salads");
            //Console.WriteLine("5-Deserts");
            //Console.WriteLine("6-Drinks");
            //Console.WriteLine("");
            //Console.WriteLine("***** Food Categories *****");

            #endregion



            #region String Variables

            //string

            //veriable_type veriable_name


            //string name;
            //name="Mustafa";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Mustafa";
            //customerSurname="ÇELİK";
            //customerPhone="+90 500 400 300 20";
            //customerEmail="xxxxxx";
            //district="Sarıyer";
            //city="İst";

            //Console.WriteLine("**** Rezervation Card ****");
            //Console.WriteLine("");
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Customer: "+customerName+" "+customerSurname);
            //Console.WriteLine("Contact: "+customerPhone);
            //Console.WriteLine("Email Address: "+customerEmail);
            //Console.WriteLine("Address: "+district+"/"+city);
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("");
            //customerName ="Test";
            //customerSurname="Arslan";
            //customerPhone="+90 300 400 500";
            //customerEmail="test@x";
            //district="Ankara";
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Customer: "+customerName+" "+customerSurname);
            //Console.WriteLine("Contact: "+customerPhone);
            //Console.WriteLine("Email Address: "+customerEmail);
            //Console.WriteLine("Address: "+district+"/"+city);
            //Console.WriteLine("-----------------------------------------------");


            #endregion


            #region İnt Veriables

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restaurant Menu Prices ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Price: "+hamburgerPrice+"$");
            Console.WriteLine("-----Coke Price: "+cokePrice+"$");
            Console.WriteLine("-----Water Price: "+waterPrice+"$");
            Console.WriteLine("-----Fries Price: "+friesPrice+"$");
            Console.WriteLine("-----Lemonade Price: "+lemonadePrice+"$");
            Console.WriteLine();
            Console.WriteLine("**** Restaurant Menu Prices ****");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount=3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;

            totalHamburgerPrice=hamburgerCount*hamburgerPrice;
            totalCokePrice=cokeCount*cokePrice;
            totalWaterPrice=waterCount*waterPrice;
            totalFriesPrice=friesCount*friesPrice;
            totalLemonadePrice=lemonadeCount*lemonadePrice;
            totalPizzaPrice=pizzaCount*pizzaPrice;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Total: "+totalHamburgerPrice+"$");
            Console.WriteLine("Pizza Total: "+totalPizzaPrice+"$");
            Console.WriteLine("Cola Total: "+totalCokePrice+"$");
            Console.WriteLine("Fries Total: "+totalFriesPrice+"$");
            Console.WriteLine("Water Total: "+totalWaterPrice+"$");
            Console.WriteLine("Lemonade Total: "+totalLemonadePrice+"$");

            Console.WriteLine();

            int totalPrice=totalPizzaPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalLemonadePrice+totalHamburgerPrice;

            Console.WriteLine("Total Price: "+totalPrice+"$");

            #endregion


            Console.Read();
        }
    }
}
