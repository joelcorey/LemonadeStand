using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace LemonadeStand
{
    class Database : APIKey
    {
        public async void DatabaseConnect()
        {
            var client = new HttpClient();
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("task", task));
            values.Add(new KeyValuePair<string, string>("merchant", merchant_id));
            values.Add(new KeyValuePair<string, string>("ref", ref);
            // include other fields
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://voguepay.com/api/", content);

            
        }

        private void DatabaseSetup()
        {

        }
    }
}
