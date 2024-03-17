int number = int.Parse(Console.ReadLine());

PrintNumber(number);
static void PrintNumber(int num)
{
    if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else if (num < 0)
    {
        Console.WriteLine($"The number {num} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {num} is zero.");
    }
}
