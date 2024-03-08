string input = Console.ReadLine();

while (input != "End")
{
    int number = int.Parse(input);
    int sumOfDigits = 0;

    while (number > 0)
    {
        int digit = number % 10;
        sumOfDigits += digit;
        number /= 10;
    }
    Console.WriteLine($"Sum of digits = {sumOfDigits}");
    
    input = Console.ReadLine();

    if (input == "End")
        Console.WriteLine("Goodbye");
}
