using System;
using Newtonsoft.Json;

namespace BitfinexAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticker ticker = new Ticker();
            ticker.Market();
            Console.WriteLine(ticker.ValueAsk);
            Console.WriteLine(ticker.ValueBid);
        }
    }
}
