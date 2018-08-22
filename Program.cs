using System;
using System.Collections.Generic;
using System.Linq;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
                ("dog", 13.40, 3),
                ("cat", 11.02, 2),
                ("bird", 1.05, 1),
                ("snake", 33.08, 15),
                ("mouse", 0.44, 15)
            };
            int totalQuant = transactions.Sum(x => x.quantity);
            double totalSales = transactions.Sum(x => x.quantity * x.amount);

            Console.WriteLine($"Total Quantity: {totalQuant}  Total Sales: ${totalSales} \n -------");
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks["GM"] = "General Motors";
            stocks["CAT"] = "Caterpillar";
            stocks["DIS"] = "Disney";
            stocks["AAPL"] = "Apple";

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 60, price: 19.02));
            purchases.Add((ticker: "GM", shares: 140, price: 21.21));
            purchases.Add((ticker: "DIS", shares: 32, price: 171.87));
            purchases.Add((ticker: "DIS", shares: 81, price: 191.02));
            purchases.Add((ticker: "GM", shares: 50, price: 13.21));
            purchases.Add((ticker: "AAPL", shares: 132, price: 117.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            Dictionary<string, double> totOwnRep = new Dictionary<string, double>();
            // Console.WriteLine(purchases[3]);
            foreach ((string ticker, int shares, double price) purchase in purchases){
                if (totOwnRep.ContainsKey(stocks[purchase.ticker])){
                    totOwnRep[stocks[purchase.ticker]] += purchase.shares * purchase.price;
                } else {
                    totOwnRep[stocks[purchase.ticker]] = purchase.shares * purchase.price;
                }
            }

            foreach(KeyValuePair<string, double> kvp in totOwnRep) {
                Console.WriteLine("{0}: {1:0.00}", kvp.Key, kvp.Value);
            }
            



        }
    }
}
