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

            
            
            // Convert week to object:
            week = 1;

            
            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)
        }
        public void GameLoop()
        {
            Player playerOne = new Player("Player one", 10.10, 0);
            UserInterface.DisplayDouble(playerOne.Money);


            Console.ReadLine();
            
        }
    }
}
