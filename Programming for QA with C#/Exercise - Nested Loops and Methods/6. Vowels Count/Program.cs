string word = Console.ReadLine();

int vowelsCount = CountVowerlsInCount(word);
Console.WriteLine(vowelsCount);
static int CountVowerlsInCount(string text)
{ 
int vowelsCount = 0;
for (int i = 0; i < text.Length; i++)
    {
        char symbol = char.ToLower(text[i]);
        if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
        {
            vowelsCount++;
        }

    }
    return vowelsCount;
}