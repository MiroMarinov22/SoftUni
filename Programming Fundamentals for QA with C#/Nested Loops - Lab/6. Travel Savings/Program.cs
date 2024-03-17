string destination = Console.ReadLine();

while (destination != "End")
{
    double neededBudget = double.Parse(Console.ReadLine());
    double sum = 0;

    while (sum < neededBudget)
    {
        double currentAmount = double.Parse((Console.ReadLine()));
        sum += currentAmount;
        Console.WriteLine($"Collected: {sum:F2}");
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}



