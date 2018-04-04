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
                inputValidator = inputStoreHandler.InputValidation(options = new List<string>(new string[] { "L", "P", "C" }), playerInput);
                if (inputValidator)
                {
                    if (playerInput == "L") //lemon
                    {

                    }
                    if (playerInput == "P") //pitcher
                    {

                    }
                    if (playerInput == "C") //cup
                    {

                    }

                }
            }
        }
        
    }
}
