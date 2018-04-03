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
        Day day;
        Random rnd = new Random();
        public int dayTracker = 1;
        public int dayLimit = 20;
        public int week = 1;

        // Constructor

        // Member methods 
        public void GameStart()
        {
            
            
            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)

            
        }

        public void GameLoop()
        {
            Player playerOne = new Player("Player one", 10.00, 0);
            //UserInterface.DisplayDouble(playerOne.Money);
            Weather weather = new Weather();

            // Go to market/store and buy pitchers, lemons, sugar, etc
            // subtract money
            // put items in inventory

            while (dayTracker <= dayLimit)
            {
                day = new Day(weather.getTemperatureFromApi("http://api.wunderground.com/api/" + Credentials.token + "/conditions/q", weather.GetLocatinoForApi(rnd.Next(1, 10))));



                Console.WriteLine(day.GetDayName(dayTracker));
                Console.WriteLine("Week: " + week);
                Console.WriteLine("Today's temperature is: " + day.dayTemperature);
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
