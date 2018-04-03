using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayBasicInterface(string day, int week, int temperature)
        {
            Console.WriteLine(day);
            Console.WriteLine("Week: " + week);
            Console.WriteLine("Today's temperature is: " + temperature);
        }
        
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
