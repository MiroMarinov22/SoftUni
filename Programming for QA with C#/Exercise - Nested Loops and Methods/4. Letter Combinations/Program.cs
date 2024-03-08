char startLetter = char.Parse(Console.ReadLine());
char lastLetter = char.Parse(Console.ReadLine());
char excludedletter = char.Parse(Console.ReadLine());

int count = 0;

for (char i = startLetter; i <= lastLetter; i++)
{
    for (char j = startLetter; j <= lastLetter; j++)
    {
        for (char k = startLetter; k <= lastLetter; k++)
        {
            if (i != excludedletter && j != excludedletter && k != excludedletter)
            {
                Console.Write($"{i}{j}{k} ");
                count++;
            }
        }
    }
}

Console.WriteLine(" ");
Console.WriteLine($"{count}");