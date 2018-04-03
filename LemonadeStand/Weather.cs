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
        
        // Constructor

        // Member methods     
        public string GetLocatinoForApi(int weatherLocation)
        {
            switch (weatherLevel)
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
