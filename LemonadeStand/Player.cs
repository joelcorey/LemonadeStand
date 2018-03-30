using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // Member variables
        private string name;
        private double money;
        private int level;

        public string Name
        {
            get { return name; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        // Constructor
        public Player(string name, double money, int level)
        {
            this.name = name;
            this.money = money;
            this.level = level;
        }

        //public Derp()
        //{

        //} 

        
        // Member methods

    }
}
