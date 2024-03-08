double balance = 0;

while (true)
{
    string word = (Console.ReadLine());
    if (word == "End")
    {
        break;
    }
    if (double.TryParse(word, out double number))
    {
        if (number > 0)
        {
            Console.WriteLine($"Increase: {number:F2}");
            balance += number;
        }
        else if (number < 0)
        {
            Console.WriteLine($"Decrease: {Math.Abs(number):F2}");
            balance -= Math.Abs(number);
        }
    }
}

Console.WriteLine($"Balance: {balance:F2}");

