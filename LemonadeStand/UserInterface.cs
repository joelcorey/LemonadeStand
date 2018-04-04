using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayMainTitle()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
        }
        public static void DisplayBasicInterface(string day, int week, int temperature)
        {
            Console.WriteLine(day);
            Console.WriteLine("Week: " + week);
            Console.WriteLine("Today's temperature is: " + temperature);
        }

        public static void DisplayInput()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("You options are: (R)ecipe, (S)tore, (C)raft");
        }

        public static void DisplayBasicStore()
        {
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("Cost per lemon: 10");
            Console.WriteLine("How many lemonds would you like to buy today?");
        }
        
        public static void Display(string input)
        {
            Console.WriteLine(input);
        }

        public static void DisplayDouble(double input)
        {
            Console.WriteLine("{0:0.00}", input);
        }

        public static string GetInput()
        { 
            return Console.ReadLine();
        }

    }
}
