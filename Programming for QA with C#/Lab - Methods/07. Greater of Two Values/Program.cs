string type = Console.ReadLine();

if (type == "int")
{
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());

    Console.WriteLine(GetGreatestNumber(number1, number2));
}

else if (type == "string")
{
    string word1 = Console.ReadLine();
    string word2 = Console.ReadLine();

    Console.WriteLine(GetGreatestString(word1, word2));
}

else if (type == "char")
{
    char char1 = char.Parse(Console.ReadLine());
    char char2 = char.Parse(Console.ReadLine());

    Console.WriteLine(GetGreatestChar(char1, char2));
}

static int GetGreatestNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

static string GetGreatestString(string w1, string w2)
{
    if (w1.CompareTo(w2) > 0 )
    {
        return w1;
    }
    else
    {
        return w2;
    }
}

static char GetGreatestChar(char letter1, char letter2)
{ 
    if (letter1 > letter2)
    {
        return letter1;
    }
    else
    {
        return letter2;
    }
}