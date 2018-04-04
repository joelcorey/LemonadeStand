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
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<Pitcher> pitchers;

        // Constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            cups = new List<Cup>();
            pitchers = new List<Pitcher>();
        }

        // Member methods
        public void AddLemon(int age, double cost, int amount)
        {
            for (int i = 0; i <= amount; i++)
            {
                lemons.Add(new Lemon(age, cost));
            }
        }

        public void AddCup(double cost, int amount)
        {
            for (int i = 0; i <= amount; i++)
            {
                cups.Add(new Cup(cost));
            }
        }

        public void AddPitcher(double cost, int amount)
        {
            for (int i = 0; i <= amount; i++)
            {
                pitchers.Add(new Pitcher(cost));
            }
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
