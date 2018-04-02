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
            string connectionString = @"Data Source=C:\install\project\devcode\visualStudio2015\projects\LemonadeStand\lemonadestand.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

            Database database = new Database();
            database.DatabaseConnect(connectionString);
            //database.DatabaseInsertScore("Derplestein", 9001);
            database.DatabaseShowScore();
            database.DatabaseClose();
            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)
        }

        public void GameLoop()
        {
            Player playerOne = new Player("Player one", 10.00, 0);
            //UserInterface.DisplayDouble(playerOne.Money);


            // Go to market/store and buy pitchers, lemons, sugar, etc
            // subtract money
            // put items in inventory

            Console.ReadLine();
            
        }
    }
}
