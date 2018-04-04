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
        public Day day;
        public Store store;
        public Random rnd = new Random();
        public int dayTracker = 1;
        public int dayLimit = 20;
        public int week = 1;
        public List<Player> players;

        // Constructor

        // Member methods 
        public void GameStart()
        {
            InputHandler inputHandler = new InputHandler;
            players = new List<Player>();

            UserInterface.DisplayMainTitle();

            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)


        }

        public void GameLoop()
        {
            Player playerOne = new Player("Player one", 10.00, 0);
            Player playerTwo = new Player("Player one", 10.00, 0);
            players.Add(playerOne);
            players.Add(playerTwo);

            Weather weather = new Weather();
            store = new Store();



            while (dayTracker <= dayLimit)
            {
                //day = new Day(weather.GetTemperatureFromApi("http://api.wunderground.com/api/" + Credentials.token + "/conditions/q", weather.GetLocatinoForApi(rnd.Next(1, 10)), rnd.Next(1, 10)));
                day = new Day(weather.GetTemperatureFallback(rnd.Next(1, 10)));

                foreach (var player in players)
                {
                    // TODO: handle all turn specifics here
                    //UserInterface.Display ... display whose turn it is here

                    UserInterface.DisplayBasicInterface(day.GetDayName(dayTracker), week, day.dayTemperature);


                    player.inventory.AddLemon(rnd.Next(1, 10));

                }


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
