using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayClear()
        {
            Console.Clear();
        }
        public static void DisplayMainTitle()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
        }

        public static void DisplayWhoseTurn(string player)
        {
            Console.WriteLine("It is " + player + "'s turn");
        }
        public static void DisplayBasicInterface(string day, int week, int temperature)
        {
            Console.WriteLine("Day: " + day + ", Week: " + week + ", Temperature: " + temperature);
        }

        public static void DisplayInput()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Your options are: (S)tore, (E)nd turn");
        }

        public static void DisplayBasicStore()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("Cost per lemon: 0.10, cost per cup: 0.05, cost per pitcher: 1.00");
            Console.WriteLine("Options:");
            Console.WriteLine("Buy (L)emon, (C)up, (P)ither, (E)xit store");
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
