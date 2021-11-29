using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ApisKanyeandRon
{
    public class QuoteGenerator
    {
        public QuoteGenerator()
        {




        }


        public static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var KanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var KanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {KanyeQuote}");
        }

        

        public static void Ronresponse()
        {
            var client = new HttpClient();
            var RonSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var RonResponse = client.GetStringAsync(RonSwansonURL).Result;
            var RonQuote = JArray.Parse(RonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"RonSwanson: {RonQuote}");

        }
    }
}
