int number = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(GetMultipleOffEvenAndOdd(number));
static int GetSumOfEvenDigits (int num)
{
    int sum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;

        if (digit % 2 == 0)
        {
            sum += digit;
        }
    }

    return sum;
}

static int GetSumOfOddDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;

        if (digit % 2 != 0)
        {
            sum += digit;
        }
    }

    return sum;
}

static int GetMultipleOffEvenAndOdd(int num)
{
    return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
}