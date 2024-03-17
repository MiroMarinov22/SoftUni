int stopNumber = int.Parse(Console.ReadLine());
int previousNumber = 0;
int currentNumber = 0;

while (currentNumber != stopNumber)
{
    currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber == stopNumber)
    {
        break;
    }
    previousNumber = currentNumber;
}

double bonus = previousNumber * 0.2;
double result = previousNumber + bonus;

Console.WriteLine(result);
