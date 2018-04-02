using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LemonadeStand
{
    class Weather
    {
        // Member variables
        HttpClient httpClient;

        // Constructor

        // Member methods
        public void WeatherApi()
        {
            httpClient = new HttpClient();
            var getAsync = httpClient.GetAsync("http://www.google.com").Result;
            var response = getAsync.Content;
            string responseString = response.ReadAsStringAsync().Result;

            Console.WriteLine(responseString);
        }


    }
}
