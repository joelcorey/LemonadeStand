﻿using System;
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
            Console.WriteLine("Day: " + day + " Week: " + week + " Temperature: " + temperature);
        }

        public static void DisplayInput()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("You options are: (R)ecipe, (S)tore, (C)raft", "(E)nd turn");
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
