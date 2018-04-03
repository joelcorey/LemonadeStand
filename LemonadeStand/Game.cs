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
        public string name = "Derplestein";
        // Constructor

        // Member methods 
        public void GameStart()
        {
            Database database = new Database(Configuration.databaseConnect);

            //sql = "insert into Score (Name, Score) values('" + name + "', " + rnd.Next(1, 100) + ");";
            //database.DatabaseDoCommand(sql);

            //sql = "SELECT Name, Score FROM Score ORDER BY Score;";
            //database.DatabaseShowScore(sql);

            Weather weather = new Weather(rnd.Next(1, 10));
            int temperature = weather.getTemperatureFromApi("http://api.wunderground.com/api/" + Credentials.token + "/conditions/q", "/WI/Milwaukee.json");



            
            Console.WriteLine(temperature);
            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)

            database.DatabaseClose();
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
                day = new Day();





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
