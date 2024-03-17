int numberOfCommands = int.Parse(Console.ReadLine());

var users = new Dictionary<string, string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] commands = Console.ReadLine().Split();
    string command = commands[0];
    string user = commands[1];

    if (command == "register")
    {
        string plate = commands[2]; 

        if (!users.ContainsKey(user))
        {
            users.Add(user, plate);
            Console.WriteLine($"{user} registered {plate} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {plate}");
        }
    }

    else if (command == "unregister")
        if (users.ContainsKey(user))
        {
            users.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
}

foreach (var pair in users)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}