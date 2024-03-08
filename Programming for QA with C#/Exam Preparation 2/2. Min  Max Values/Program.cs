int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int number = int.Parse(Console.ReadLine());
int minNumber = int.MaxValue;
int maxNumber = int.MinValue;

for (int i = 0; i < number; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }

    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }
}

Console.WriteLine(maxNumber);
Console.WriteLine(minNumber);