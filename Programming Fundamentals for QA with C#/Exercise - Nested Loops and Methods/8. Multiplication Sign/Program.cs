int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

Console.WriteLine(FindingNumbers(number1, number2, number3));
static string FindingNumbers(int num1,  int num2, int num3)
{
    string text = "";
    if (num1 < 0 || num2 < 0 || num3 < 0)
    {
        if
            (num1 < 0 && num2 < 0 && num3 > 0 ||
            num1 < 0 && num3 < 0 && num2 > 0 ||
            num2 < 0 && num3 < 0 && num1 > 0)
        {
            text = "positive";
        }
        else
        {
            text = "negative";
        }
    }

    else if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        text = "zero";
    }

    else
    {
        text = "positive";
    }

    return text;
}