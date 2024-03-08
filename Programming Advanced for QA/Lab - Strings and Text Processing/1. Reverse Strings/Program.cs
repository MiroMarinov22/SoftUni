string input = Console.ReadLine();

while (input != "end")
{
    string reversed = string.Join("", input.Reverse().ToList());

    Console.WriteLine(input + " = " + reversed);

    input = Console.ReadLine();
}

