using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Seda Dadak
//Purpose: To create a class for following a chain of coffee shops' sell 

namespace assignment1Comp60
{
    class CoffeeShop
    {
        //step1: create private non-static varaiable class members
        private string coffeeShopName;
        private int numberOfCoffeeCupsSold;
        private int numberOfTeaCupsSold;

        //step2: create public, static variable class members
        public static double priceOfCupOfCoffee;
        public static double priceOfCupOfTea;

        //step3: create a constructor
        public CoffeeShop(string initialCoffeeShopName)
        {
            coffeeShopName = initialCoffeeShopName;
            numberOfCoffeeCupsSold = 0;
            numberOfTeaCupsSold = 0;
        }

        //step4: create non-static function for getting total
        public int GetTotalSales()
        {
            return numberOfCoffeeCupsSold + numberOfTeaCupsSold;
        }

        //step 9 : create getter and setter to assign number of cups sold which are given by user 
        public int GetNumberOfCoffeSold()
        {
            return numberOfCoffeeCupsSold;
        }

        public void SetNumberOfCoffeeSold(int passedNumberOfCoffeeSold)
        {
            
            while (passedNumberOfCoffeeSold<0 || passedNumberOfCoffeeSold >100)
            {
                Console.WriteLine("Number of cups of coffee should be between 1-100. Please re-enter!  ");
                passedNumberOfCoffeeSold = Int32.Parse(Console.ReadLine());
            }
            numberOfCoffeeCupsSold = passedNumberOfCoffeeSold;
        }
        
        public int GetNumberOfTeaSold()
        {
            return numberOfTeaCupsSold;
        }
      
        public void SetNumberOfTeaSold(int passedNumberOfTeaSold)
        {           
            while (passedNumberOfTeaSold < 0 || passedNumberOfTeaSold > 100)
            {
                Console.WriteLine("Number of cups of coffee should be between 1-100. Please re-enter! ");
                passedNumberOfTeaSold = Int32.Parse(Console.ReadLine());
            }          
            numberOfTeaCupsSold = passedNumberOfTeaSold;
        }

        // To show coffee shop name in the main program. I used getter.
        public string GetCoffeeShopName()
        {
            return coffeeShopName;
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