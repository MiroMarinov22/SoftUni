﻿int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int firstDigit = 2;  firstDigit <= max1; firstDigit += 2)
{
    for (int secondDigit = 1; secondDigit <= max2; secondDigit++)
    {
        for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit += 2)
        {
            if (IsPrime(secondDigit))
            {
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
            }  
        }
    }
}

static bool IsPrime(int number)
{
    bool IsPrime = true;

    if (number <= 1)
    {
        IsPrime = false;
    }

    else if (number > 2)
    {
        int topDivider = (int)Math.Ceiling(Math.Sqrt(number));
        for (int d = 2; d <= topDivider; d++)
        {
            if (number % d == 0)
            {
                IsPrime = false;
                break;
            }
        }
    }
    return IsPrime;
}