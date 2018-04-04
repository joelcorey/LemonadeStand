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
        public List<string> options;
        string playerInput;
        public InputHandler inputHandler;
        public InputHandler inputStore;
        public bool inputValidator;
        public bool endTurn = false;
        public bool wundergroundEnable = false;
        // Constructor

        // Member methods 
        public void GameStart()
        {
            inputHandler = new InputHandler();
            inputStore = new InputHandler();
            players = new List<Player>();

            UserInterface.DisplayMainTitle();

            // If first load, display intro and main menu
            // PvP or PvC option (CvC ?!)

        }

        public void GameLoop()
        {
            Player playerOne = new Player("Player one", 10.00m, 0);
            Player playerTwo = new Player("Player two", 10.00m, 0);
            players.Add(playerOne);
            players.Add(playerTwo);

            Weather weather = new Weather();
            store = new Store(rnd);

            while (dayTracker <= dayLimit)
            {
                if(wundergroundEnable == false)
                {
                    day = new Day(weather.GetTemperatureFallback(rnd.Next(1, 10)));
                }
                else
                {
                    day = new Day(weather.GetTemperatureFromApi("http://api.wunderground.com/api/" + Credentials.token + "/conditions/q", weather.GetLocatinoForApi(rnd.Next(1, 10)), rnd.Next(1, 10)));
                }
                
                foreach (var player in players)
                {
                    endTurn = false;
                    while (endTurn != true)
                    {
                        // TODO: handle all turn specifics here
                        UserInterface.DisplayClear();
                        UserInterface.DisplayWhoseTurn(player.Name);
                        UserInterface.DisplayMoney(player.Money);
                        UserInterface.DisplayBasicInterface(day.GetDayName(dayTracker), week, day.dayTemperature);
                        UserInterface.DisplayBasicInventory(player.inventory.lemons.Count, player.inventory.cups.Count, player.inventory.pitchers.Count);
                        UserInterface.DisplayInput();
                        playerInput = Console.ReadLine();
                        inputValidator = inputHandler.InputValidation(options = new List<string>(new string[] { "R", "S", "C", "E" }), playerInput);
                        if (inputValidator)
                        {
                            //if(playerInput == "R") // Handle recipe input
                            //if(playerInput == "C") // Handle crafting input
                            if (playerInput == "S")
                            {
                                store.StoreInterface(player);
                            }
                            if (playerInput == "E")
                            {
                                endTurn = true;
                            }
                        }
                        
                    }
                }


                dayTracker += 1;
                if (dayTracker > 7)
                {
                    week += 1;
                    dayTracker = 1;
                }
            }
        }
    }
}
