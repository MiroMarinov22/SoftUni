List<string> words = Console.ReadLine()
                            .ToLower()
                            .Split()
                            .ToList();

Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

foreach (string word in words)
{
    if (wordsCounter.ContainsKey(word))
    {
        wordsCounter[word]++;
    }
    else
    {
        wordsCounter.Add(word, 1);
    }
}

foreach (var pair in wordsCounter)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write(pair.Key + " ");
    }
}