string text = Console.ReadLine();

int sumUpperCase = 0;
int sumLowerCase = 0;
int sumWhiteSpace = 0;
foreach (char letter in  text)
{
    if (char.IsUpper(letter))
    {
        sumUpperCase++;
    }

    else if (char.IsLower(letter))
    {
        sumLowerCase++;
    }

    else if (char.IsWhiteSpace(letter))
    {
        sumWhiteSpace++;
    }
}

Console.WriteLine(sumUpperCase);
Console.WriteLine(sumLowerCase);
Console.WriteLine(sumWhiteSpace);