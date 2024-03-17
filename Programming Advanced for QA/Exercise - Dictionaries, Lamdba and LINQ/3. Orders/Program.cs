string input = Console.ReadLine();

Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    double price = double.Parse(inputArray[1]);
    double quantity = double.Parse(inputArray[2]);

    if (!orders.ContainsKey(product))
    {
        orders.Add(product, new List<double>());
        orders[product].Add(price);
        orders[product].Add(quantity);
    }
    else
    {
        orders[product][0] = price;
        orders[product][1] += quantity;
    }
    input = Console.ReadLine();
}

foreach (var pair in orders)
{
    string product = pair.Key;
    double price = pair.Value[0];
    double quantity = pair.Value[1];
    double amount = price * quantity;

    Console.WriteLine($"{product} -> {amount:F2}");
}