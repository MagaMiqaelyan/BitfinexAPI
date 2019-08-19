using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BitfinexAPI
{
    public class Ticker
    {
        public decimal ValueAsk { get; set; }
        public decimal ValueBid { get; set; }

        public void Market()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.bitfinex.com/v1/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applaction/json"));
            HttpResponseMessage responseMessage = client.GetAsync($"pubticker/btcusd").Result
            if (responseMessage.IsSuccessStatusCode)
            {
                var product = responseMessage.Content.ReadAsStringAsync().Result;
                JObject jObject = JObject.Parse(product);
                ValueAsk = (decimal)jObject["ask"];
                ValueBid = (decimal)jObject["bid"];
            }
        }
    }
}
