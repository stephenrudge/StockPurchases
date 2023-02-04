using System.Security.Cryptography;

Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
stocks.Add("TSLA", "Tesla");
stocks.Add("AAPL", "Apple");
stocks.Add("GE", "General Elctric");

string GM = stocks["GM"]; //General motors

List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

purchases.Add((ticker: "GE", shares: 150, price: 23.21));
purchases.Add((ticker: "AAPL", shares: 32, price: 17.87));
purchases.Add((ticker: "TSLA", shares: 80, price: 19.02));

Dictionary<string, Dictionary<string, string>> mycompanys = new Dictionary<string, Dictionary<string, string>>();

for (int i = 0; i < purchases.Count; i++)
{
    double totalPrice = purchases[i].price * purchases[i].shares;
    string ticker = purchases[i].ticker;

    mycompanys.Add(purchases[i].ticker, new Dictionary<string, string>() { { "name", stocks[ticker] }, { "price", totalPrice.ToString() } });
}
foreach (var company in mycompanys)
    {
        var companyValue = company.Value;

        Console.WriteLine($"You own {companyValue["name"]} at {companyValue["price"]}");
    }





  

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

