using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // Member variables
        List<Lemon> lemons;

        // Constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
        }

        // Member methods
        public void AddLemon(int age)
        {
            lemons.Add(new Lemon(age));
        }

        public void ListLemons()
        {
            foreach (var lemon in lemons)
            {
                Console.WriteLine("Lemon age: " + lemon.age);
            }
        }

    }
}
