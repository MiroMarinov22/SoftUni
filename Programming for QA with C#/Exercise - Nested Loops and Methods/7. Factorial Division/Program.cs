int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int result = CalculateFactorial(number1) / CalculateFactorial(number2);
Console.WriteLine(result);
static int CalculateFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}