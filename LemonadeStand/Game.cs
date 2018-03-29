using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // Member variables
        Random random;
        List<string> days;
        public int week;

        // Constructor

        // Member methods 
        public void GameStart()
        {
            Currency penny = new Currency("penny", 1, 0001);
            Currency dollar = new Currency("dollar", 1, 0010);
            week = 1;
            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)
        }
        public void GameLoop()
        {
            Player playerOne = new Player("Player one", 10.00, 0);

        }
    }
}
