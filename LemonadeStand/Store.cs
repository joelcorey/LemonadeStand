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
        public int pitcherCost;
        public int cupCost;
        public int lemonCost;
        public bool endStore;
        public bool inputValidator;
        public InputHandler inputStoreHandler;
        public List<string> options;
        public string playerInput;
        // Constructor

        // Member methods
        public void StoreInterface(Inventory player, Double money)
        {
            inputStoreHandler = new InputHandler();
            endStore = false;
            UserInterface.DisplayBasicStore();
            playerInput = Console.ReadLine();
            while (endStore != false)
            {
                inputValidator = inputStoreHandler.InputValidation(options = new List<string>(new string[] { "L", "P", "C", "E" }), playerInput);
                if (inputValidator)
                {
                    if (playerInput == "L")
                    {
                        UserInterface.Display("How many lemons would you like to buy?");
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
        
    }
}
