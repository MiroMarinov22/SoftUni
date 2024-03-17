int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = int.Parse(Console.ReadLine());
int arrLength = numbers.Length;

if (n > arrLength)
{
    n = arrLength;
}

int sum = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = numbers[arrLength - 1 - i];
    sum += currentNumber;
}

double lastElementAverage = (double)sum / n;
Console.WriteLine($"{lastElementAverage:F2}");