int baseNumber = int.Parse(Console.ReadLine());
int powerNumber = int.Parse(Console.ReadLine());

Console.WriteLine(GetPowerNumber(baseNumber, powerNumber));
static int GetPowerNumber(int number, int pow)
{
    int power = (int)Math.Pow(number, pow);
    return power;
}

