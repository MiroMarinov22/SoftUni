int number = int.Parse(Console.ReadLine());
string word = Console.ReadLine();

while (word != "End")
{
    if (word == "Inc")
    {
        number++;
    }
    else if (word == "Dec")
    {
        number--;
    }
    word = Console.ReadLine();
}
Console.WriteLine(number);