using System;
using RestSharp;

namespace LemonadeStand
{
    class Weather : Credentials
    {
        // Member variables


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

            var client = new RestClient("http://api.wunderground.com/api/ccd5561409db5d47/conditions/q");
            var request = new RestRequest("/WI/Milwaukee.json", Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            

            Console.WriteLine(content);
        }

    }
}
