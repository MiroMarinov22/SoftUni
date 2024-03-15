List<string> someWords = Console.ReadLine()
                         .Split()
                         .Where(words => words.Length % 2 == 0)
                         .Select(words => { Console.WriteLine(words); return words; })
                         .ToList();

