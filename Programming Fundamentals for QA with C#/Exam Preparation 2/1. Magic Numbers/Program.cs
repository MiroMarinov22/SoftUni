int number = int.Parse(Console.ReadLine());

bool isNoMagicNumber = true;

for  (int i = 1; i <= number; i++)
{
    int currentNumber = i;
    int sumDigits = 0;
    bool isAllDigitsPrime = true;

    while (currentNumber > 0)
    {
        int digit = currentNumber % 10;
        currentNumber /= 10;

        sumDigits += digit;

        if (digit != 2 && digit != 3 && digit !=5 && digit != 7)
        {
            isAllDigitsPrime = false;
        }    

    }

    if (isAllDigitsPrime && sumDigits % 2 == 0)
    {
        Console.Write(i + " ");
        isNoMagicNumber = false;
    }
}

if  (isNoMagicNumber)
{
    Console.WriteLine("no");
}