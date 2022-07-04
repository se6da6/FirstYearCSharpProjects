using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name:Seda Dadak
//Purpose: To write a program for a coffee shop chain to determine which shop made the highest sell.

namespace assignment1Comp60
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //step 7 : assigning values to prices
            CoffeeShop.priceOfCupOfCoffee = 9.0;
            CoffeeShop.priceOfCupOfTea = 5.0;

            // step 8: create two CoffeeShop objects
            CoffeeShop shopOne = new CoffeeShop("Missing Spring");
            CoffeeShop shopTwo = new CoffeeShop("Wonderful Taste");

            //To ask user for input for number of products sold and take input
            //and assigning this input to numberOfCoffeeCupsSold through setter function
            Console.WriteLine("Please enter first shop's number of cups of coffee sold. ");
            int numberOfCoffeeSoldOne = Int32.Parse(Console.ReadLine());
            shopOne.SetNumberOfCoffeeSold(numberOfCoffeeSoldOne);

            Console.WriteLine("Please enter first shop's number of cups of tea sold. ");
            int numberOfTeaSoldOne = Int32.Parse(Console.ReadLine());
            shopOne.SetNumberOfTeaSold(numberOfTeaSoldOne);

            Console.WriteLine("Please enter second shop's number of cups of coffee sold. ");
            int numberOfCoffeesSoldTwo = Int32.Parse(Console.ReadLine());
            shopTwo.SetNumberOfCoffeeSold(numberOfCoffeesSoldTwo);

            Console.WriteLine("Please enter second shop's number of cups of tea sold. ");
            int numberOfTeaSoldTwo = Int32.Parse(Console.ReadLine());
            shopTwo.SetNumberOfTeaSold(numberOfTeaSoldTwo);
            
            //display which coffee shop sell how many products.
            Console.WriteLine(shopOne.GetCoffeeShopName()+ " sold " + shopOne.GetNumberOfCoffeSold() + " cups of coffee. " );             
            Console.WriteLine(shopOne.GetCoffeeShopName()+ " sold " + shopOne.GetNumberOfTeaSold() + " cups of tea. ");
            Console.WriteLine(shopTwo.GetCoffeeShopName() + " sold " + shopTwo.GetNumberOfCoffeSold() + " cups of coffee. " );
            Console.WriteLine(shopTwo.GetCoffeeShopName() + " sold " + shopTwo.GetNumberOfTeaSold() + " cups of tea. ");


            // step 10: Display totalsales
            shopOne.GetTotalSales();
            shopTwo.GetTotalSales();

            // step 11: call the DisplayBestShop function 
            DisplayBestShop("Missing Spring");

            Console.WriteLine("Press enter to continue. ");
            Console.ReadLine();
        }

        //step 6: create a function to determine the winner shop
        static void DisplayBestShop(string passedNameOfCoffeeShop)
        {
            Console.WriteLine(passedNameOfCoffeeShop + " is the winner. ");
        }
    }
}
/*Please enter first shop's number of cups of coffee sold.
-10
Number of cups of coffee should be between 1-100. Please re-enter!
100
Please enter first shop's number of cups of tea sold.
-6
Number of cups of coffee should be between 1-100. Please re-enter!
60
Please enter second shop's number of cups of coffee sold.
96
Please enter second shop's number of cups of tea sold.
45
Missing Spring sold 100 cups of coffee.
Missing Spring sold 60 cups of tea.
Wonderful Taste sold 96 cups of coffee.
Wonderful Taste sold 45 cups of tea.
Missing Spring is the winner.
Press enter to continue.*/
