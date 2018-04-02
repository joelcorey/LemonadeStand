﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace LemonadeStand
{
    class WeatherAPI : Credentials
    {
        // Member variables
        List<string> wundergroundCities;

        // Constructor

        // Member methods
        public void WeatherApi()
        {
            //httpClient = new HttpClient();
            //var getAsync = httpClient.GetAsync("http://www.google.com").Result;
            //var response = getAsync.Content;
            //string responseString = response.ReadAsStringAsync().Result;

            //Console.WriteLine(responseString);
        }
        
    
        public async void WeatherApi2()
        {

            //http://api.wunderground.com/api/ccd5561409db5d47/geolookup/conditions/q/WI/Milwaukee.json")

            List<string> wundergroundCities = new List<string>(new string[] { "/WI/Milwaukee.json", "/OR/Moro.json" });

            foreach (var city in wundergroundCities)
            {
                var client = new RestClient("http://api.wunderground.com/api/ccd5561409db5d47/conditions/q");
                //var request = new RestRequest("/WI/Milwaukee.json", Method.GET);
                var request = new RestRequest(city, Method.GET);

                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string
                var objectResponse = JsonConvert.DeserializeObject<dynamic>(content);

                string location = objectResponse.current_observation.display_location.full;
                string temperature = objectResponse.current_observation.temp_f;
                string humidity = objectResponse.current_observation.relative_humidity;
                string windChill = objectResponse.current_observation.windchill_f;
                string weatherDescription = objectResponse.current_observation.weather;

                //Console.WriteLine(objectResponse);
                Console.WriteLine(location);
                Console.WriteLine(temperature);
                Console.WriteLine(humidity);
                Console.WriteLine(windChill);
                Console.WriteLine(weatherDescription);
            }
        }
    }
}
