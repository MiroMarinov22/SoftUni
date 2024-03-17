char letter = char.Parse(Console.ReadLine());

if (letter == 'a' ||
    letter == 'A' ||
    letter == 'e' ||
    letter == 'E' ||
    letter == 'i' ||
    letter == 'I' ||
    letter == 'o' ||
    letter == 'O' ||
    letter == 'u' ||
    letter == 'U')
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}
