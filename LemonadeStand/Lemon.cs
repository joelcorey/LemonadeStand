using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {
        public int age;
        public Lemon(int age, double cost)
        {
            this.age = age;
            this.cost = cost;
        }
    }
}
