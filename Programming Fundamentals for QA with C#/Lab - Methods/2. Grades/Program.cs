double grade = double.Parse(Console.ReadLine());    

PrintGrade(grade);

static void PrintGrade(double number)
{
    if (number < 3)
    {
        Console.WriteLine("Fail");
    }
    else if (number < 3.50)
    {
        Console.WriteLine("Average");
    }
    else if (number < 4.50)
    {
        Console.WriteLine("Good");
    }
    else if (number < 5.50)
    {
        Console.WriteLine("Very good");
    }
    else
    {
        Console.WriteLine("Excellent");
    }
}