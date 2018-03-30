using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        
        public static void DisplayText(string input)
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
