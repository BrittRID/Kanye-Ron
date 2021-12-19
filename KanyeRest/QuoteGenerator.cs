using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeRest
{
   public class QuoteGenerator
    {
        public static void KanyeQuote()
        {

            

            var client = new HttpClient();

            var KanyeURL = " https://api.kanye.rest";

            var KenyaResponse = client.GetStringAsync(KanyeURL).Result;

            var KanyeQuote = JObject.Parse(KenyaResponse).GetValue("quote").ToString();


            Console.WriteLine($"------------------");
            Console.WriteLine($"Kanye:    {KanyeQuote}");
            Console.WriteLine($"-------------------");

        }

        public static void RonQuote()
        {

            var client = new HttpClient();

            var ronURL = ("https://ron-swanson-quotes.herokuapp.com/v2/quotes");

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"------------------");
            Console.WriteLine($"Ron:    {ronQuote}");
            Console.WriteLine($"-------------------");


        }



    }
}
