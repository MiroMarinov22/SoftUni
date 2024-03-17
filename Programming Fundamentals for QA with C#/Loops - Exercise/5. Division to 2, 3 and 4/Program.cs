int number = int.Parse(Console.ReadLine());

double numsDividedByTwoMod0Count = 0;
double numsDividedByThreeMod0Count = 0;
double numsDividedByFourMod0Count = 0;

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
    {
        numsDividedByTwoMod0Count++;
    }

    if (currentNumber % 3 == 0)
    {
        numsDividedByThreeMod0Count++;
    }

    if (currentNumber % 4 == 0)
    {
        numsDividedByFourMod0Count++;
    }
}

numsDividedByTwoMod0Count = numsDividedByTwoMod0Count / number * 100;
numsDividedByThreeMod0Count = numsDividedByThreeMod0Count / number * 100;
numsDividedByFourMod0Count = numsDividedByFourMod0Count / number * 100;

Console.WriteLine($"{numsDividedByTwoMod0Count:F2}%");
Console.WriteLine($"{numsDividedByThreeMod0Count:F2}%");
Console.WriteLine($"{numsDividedByFourMod0Count:F2}%");
