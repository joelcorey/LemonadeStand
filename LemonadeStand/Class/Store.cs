using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // Member variables
        public double pitcherCost = 1.00;
        public double cupCost = 0.05;
        public double lemonCost = 0.10;
        public bool endStore = false;
        public bool inputValidator;
        public InputHandler inputStoreHandler;
        public List<string> options;
        public string playerInput;
        public int amountInput = 0;
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

            UserInterface.DisplayBasicInventory(player.inventory.lemons.Count, player.inventory.cups.Count, player.inventory.pitchers.Count);
            UserInterface.DisplayBasicStore();
            playerInput = Console.ReadLine();
            while (endStore != true)
            {
                inputValidator = inputStoreHandler.InputValidation(options = new List<string>(new string[] { "L", "P", "C", "E" }), playerInput);
                if (inputValidator)
                {
                    if (playerInput == "L")
                    {
                        BuyLemons(player);
                    }
                    if (playerInput == "C")
                    {
                        BuyCups(player);
                    }
                    if (playerInput == "P")
                    {
                        BuyPitchers(player);
                    }
                    if (playerInput == "E")
                    {
                        endStore = true;
                    }
                }
            }
        }

        public void BuyLemons(Player player)
        {
            UserInterface.Display("How many lemons would you like to buy? Amount or (E)xit");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (amountInput * lemonCost <= player.Money)
            {
                player.inventory.AddLemon(rnd.Next(1, 10), lemonCost, amountInput);
                player.Money -= lemonCost;
                endStore = true;
            }            
        }

        public void BuyCups(Player player)
        {
            UserInterface.Display("How many cups would you like to buy? Amount or (E)xit");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (amountInput * cupCost <= player.Money)
            {
                player.inventory.AddCup(cupCost, amountInput);
                player.Money -= cupCost;
                endStore = true;
            }
        }

        public void BuyPitchers(Player player)
        {
            UserInterface.Display("How many pitchers would you like to buy? Amount or (E)xit");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (amountInput * pitcherCost <= player.Money)
            {
                player.inventory.AddPitcher(pitcherCost, amountInput);
                player.Money -= pitcherCost;
                endStore = true;
            }
        }


    }
}
