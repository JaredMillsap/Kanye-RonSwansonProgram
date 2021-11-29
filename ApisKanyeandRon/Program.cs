using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ApisKanyeandRon
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                QuoteGenerator.KanyeQuote();
                
                QuoteGenerator.Ronresponse();
                Console.WriteLine("--------------------");
            }
           

        }

    }
}
