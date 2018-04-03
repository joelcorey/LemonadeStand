using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace LemonadeStand
{
    class Weather
    {
        // Member variables
                
        // Constructor

        // Member methods     
        public string GetLocatinoForApi(int weatherLocation)
        {
            switch (weatherLocation)
            {
                case 1:
                    return Configuration.wundergroundCities[0];
                case 2:
                    return Configuration.wundergroundCities[1];
                case 3:
                    return Configuration.wundergroundCities[2];
                case 4:
                    return Configuration.wundergroundCities[3];
                case 5:
                    return Configuration.wundergroundCities[4];
                case 6:
                    return Configuration.wundergroundCities[5];
                case 7:
                    return Configuration.wundergroundCities[6];
                case 8:
                    return Configuration.wundergroundCities[7];
                case 9:
                    return Configuration.wundergroundCities[8];
                case 10:
                    return Configuration.wundergroundCities[9];
                default:
                    return Configuration.wundergroundCities[5]; 
            }
        }

        public int GetTemperatureFromApi(string baseUrl, string location, int random)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(location, Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.StatusCode); // http response code .. if bad do somethine else
            if (response.StatusCode.ToString() == "OK")
            {
                var content = response.Content; // raw content as string
                var objectResponse = JsonConvert.DeserializeObject<dynamic>(content);
                return objectResponse.current_observation.temp_f;
            }
            else
            {
                Console.WriteLine("API call fail, using fallback");
                return GetTemperatureFallback(random);
            }
        }

        public int GetTemperatureFallback(int random)
        {
            switch (random)
            {
                case 1:
                    return 10;
                case 2:
                    return 20;
                case 3:
                    return 30;
                case 4:
                    return 40;
                case 5:
                    return 50;
                case 6:
                    return 60;
                case 7:
                    return 70;
                case 8:
                    return 80;
                case 9:
                    return 90;
                case 10:
                    return 100;
                default:
                    return 75;
            }
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
