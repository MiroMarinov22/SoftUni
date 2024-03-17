string resource = Console.ReadLine();

Dictionary<string, int> miner = new Dictionary<string, int>();

while ( resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (miner.ContainsKey(resource))
    {
        miner[resource] += quantity;
    }
    else
    {
        miner.Add(resource, quantity);
    }
    resource = Console.ReadLine();
}

foreach (var pair in miner)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}