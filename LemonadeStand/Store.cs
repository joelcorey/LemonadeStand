﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // Member variables
        public double pitcherCost;
        public double cupCost;
        public double lemonCost;
        public bool endStore;
        public bool inputValidator;
        public InputHandler inputStoreHandler;
        public List<string> options;
        public string playerInput;
        public int amountInput;
        public Random rnd;

        // Constructor
        public Store(Random rnd)
        {
            this.rnd = rnd;
        }

        // Member methods
        public void StoreInterface(Player player)
        {
            
            inputStoreHandler = new InputHandler();
            endStore = false;
            UserInterface.DisplayBasicStore();
            playerInput = Console.ReadLine();
            while (endStore != true)
            {
                inputValidator = inputStoreHandler.InputValidation(options = new List<string>(new string[] { "L", "P", "C", "E" }), playerInput);
                if (inputValidator)
                {
                    if (playerInput == "L")
                    {
                        BuyLemons(player.Money);
                    }
                    if (playerInput == "P")
                    {
                        UserInterface.Display("How many pitchers would you like to buy?");
                    }
                    if (playerInput == "C")
                    {
                        UserInterface.Display("How many cups would you like to buy?");
                    }
                    if (playerInput == "E")
                    {
                        endStore = true;
                    }
                }
            }
        }

        public void BuyLemons(Player player, Double lemonCost)
        {
            UserInterface.Display("How many lemons would you like to buy?");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (true)
            {
                player.inventory.AddLemon(rnd.Next(1, 10), lemonCost);
            }
            
        }
    }
}
