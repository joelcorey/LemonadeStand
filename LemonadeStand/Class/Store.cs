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
            
            UserInterface.DisplayBasicStore();
            playerInput = Console.ReadLine();
            while (endStore != true)
            {
                inputValidator = inputStoreHandler.InputValidation(options = new List<string>(new string[] { "L", "P", "C", "E" }), playerInput);
                if (inputValidator)
                {
                    if (playerInput == "L")
                    {
                        BuyLemons(player.Money, player.inventory);
                    }
                    if (playerInput == "C")
                    {
                        BuyCups(player.Money, player.inventory);
                    }
                    if (playerInput == "P")
                    {
                        BuyPitchers(player.Money, player.inventory);
                    }
                    if (playerInput == "E")
                    {
                        endStore = true;
                    }
                }
            }
        }

        public void BuyLemons(double money, Inventory inventory)
        {
            UserInterface.Display("How many lemons would you like to buy?");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (amountInput * lemonCost <= money)
            {
                inventory.AddLemon(rnd.Next(1, 10), lemonCost, amountInput);
            }
        }

        public void BuyCups(double money, Inventory inventory)
        {
            UserInterface.Display("How many cups would you like to buy?");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (amountInput * cupCost <= money)
            {
                inventory.AddCup(cupCost, amountInput);
            }
        }

        public void BuyPitchers(double money, Inventory inventory)
        {
            UserInterface.Display("How many pitchers would you like to buy?");
            amountInput = Convert.ToInt32(Console.ReadLine());
            if (amountInput * pitcherCost <= money)
            {
                inventory.AddPitcher(pitcherCost, amountInput);
            }
        }


    }
}
