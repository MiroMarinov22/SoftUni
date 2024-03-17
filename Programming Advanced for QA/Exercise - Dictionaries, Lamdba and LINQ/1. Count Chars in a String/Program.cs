﻿string input = Console.ReadLine();

Dictionary<char, int> characters =  new Dictionary<char, int>();

foreach (var ch in input)
{
    if (ch != ' ')
    {
        if (characters.ContainsKey(ch))
        {
            characters[ch]++;
        }
        else
        {
            characters.Add(ch, 1);
        }
    }
}

foreach (var pair in characters)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}