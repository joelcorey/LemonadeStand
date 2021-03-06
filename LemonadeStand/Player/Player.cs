﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        // Member variables
        private string name;
        private decimal money;
        private int level;
        public Inventory inventory; 

        public string Name
        {
            get { return name; }
        }

        public decimal Money
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
        public Player(string name, decimal money, int level)
        {
            this.name = name;
            this.money = money;
            this.level = level;
            inventory = new Inventory();
        }
       
        // Member methods

        
    }
}
