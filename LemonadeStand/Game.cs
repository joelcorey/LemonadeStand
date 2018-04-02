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

        public int dayTracker = 1;
        public int dayLimit = 20;
        public int week = 1;


        // Constructor

        // Member methods 
        public void GameStart()
        {
            //string connectionString = @"Data Source=C:\install\project\devcode\visualStudio2015\projects\LemonadeStand\lemonadestand.db; Version=3; FailIfMissing=True; Foreign Keys=True;";
            //Database database = new Database();
            //database.DatabaseConnect(connectionString);
            //database.DatabaseInsertScore("Derplestein", 9001);
            //database.DatabaseShowScore();
            //database.DatabaseClose();



            Weather weather = new Weather();
            //weather.WeatherApi2();

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

            while (dayTracker <= dayLimit)
            {
                Day day = new Day();





                Console.WriteLine(day.GetDayName(dayTracker));
                Console.WriteLine("Week: " + week);
                dayTracker += 1;
                if (dayTracker > 7)
                {
                    week += 1;
                    dayTracker = 1;
                }

                Console.ReadLine();
            }
            
        }
    }
}
