int[] array = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
int startNumber = int.Parse(Console.ReadLine());
int lastNumber = int.Parse(Console.ReadLine());

int sum = 0;
int minNumber = int.MaxValue;
int maxNumber = int.MinValue;

if (startNumber >= 0 && startNumber < array.Length && lastNumber >= 0 && lastNumber < array.Length)
{
    for (int i = startNumber; i <= lastNumber; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }

        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }

        sum = minNumber + maxNumber;
    }
}
Console.WriteLine(sum);