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

        // Constructor

        // Member methods
        public void StoreInterface(Player player)
        {
            UserInterface.DisplayBasicStore();
        }
        
    }
}
