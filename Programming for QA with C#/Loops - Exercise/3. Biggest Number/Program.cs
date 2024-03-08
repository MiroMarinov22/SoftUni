int number = int.Parse(Console.ReadLine());

int maximumNumber = int.MinValue;

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber > maximumNumber)
    {
        maximumNumber = currentNumber;
    }
}
Console.WriteLine(maximumNumber);