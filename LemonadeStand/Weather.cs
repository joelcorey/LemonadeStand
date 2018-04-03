using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace LemonadeStand
{
    class Weather
    {
        // Member variables
        public int weatherLevel;
        public List<string> wundergroundCities = new List<string>(new string[] {
            "/ak/anchorage.json",
            "/il/chicago.json",
            "/hi/honolulu.json",
            "/ca/losangeles.json",
            "/fl/miami.json",
            "/wi/milwaukee.json",
            "/or/moro.json",
            "/or/portland.json",
            "/wa/seattle.json",
            "/wa/spokane.json"
        });

        // Constructor
        public Weather(int weatherLevel)
        {
            this.weatherLevel = weatherLevel;
        }

        // Member methods     
        public int GetWeather(int weatherLevel)
        {
            switch (weatherLevel)
            {
                case 1:
                    return weatherLevel = 10;
                case 2:
                    return weatherLevel = 20;
                case 3:
                    return weatherLevel = 30;
                case 4:
                    return weatherLevel = 40;
                case 5:
                    return weatherLevel = 50;
                case 6:
                    return weatherLevel = 60;
                case 7:
                    return weatherLevel = 70;
                case 8:
                    return weatherLevel = 80;
                case 9:
                    return weatherLevel = 90;
                case 10:
                    return weatherLevel = 100;
                default:
                    return weatherLevel = 65;
            }
        }

        public void SetupWeatherTable()
        {
            Database database = new Database(Configuration.databaseConnect);
            database.DatabaseDoCommand("CREATE TABLE IF NOT EXISTS Weather(name VARCHAR(50), temperature INT)");
            database.DatabaseClose();
        }

        public int getTemperatureFromApi(string baseUrl, string location)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(location, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            var objectResponse = JsonConvert.DeserializeObject<dynamic>(content);
            return objectResponse.current_observation.temp_f;
        }

        //public async void WUndergroundGet()
        //{ 
        //    foreach (var city in wundergroundCities)
        //    {
        //        var client = new RestClient("http://api.wunderground.com/api/" + Credentials.token + "/conditions/q");
        //        //var request = new RestRequest("/WI/Milwaukee.json", Method.GET);
        //        var request = new RestRequest(city, Method.GET);

        //        IRestResponse response = client.Execute(request);
        //        var content = response.Content; // raw content as string
        //        var objectResponse = JsonConvert.DeserializeObject<dynamic>(content);

        //        string location = objectResponse.current_observation.display_location.full;
        //        string temperature = objectResponse.current_observation.temp_f;
        //        string humidity = objectResponse.current_observation.relative_humidity;
        //        string windChill = objectResponse.current_observation.windchill_f;
        //        string weatherDescription = objectResponse.current_observation.weather;

        //        //Console.WriteLine(objectResponse);
        //        Console.WriteLine("Location: " + location);
        //        Console.WriteLine("Temperature(f): " + temperature);
        //        Console.WriteLine("Humidity: " + humidity);
        //        Console.WriteLine("Windchill: " + windChill);
        //        Console.WriteLine("Description: " + weatherDescription);
        //        Console.WriteLine("---");
        //    }
        //}
    }
}
