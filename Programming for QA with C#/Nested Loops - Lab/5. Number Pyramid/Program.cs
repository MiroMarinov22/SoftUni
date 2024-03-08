int number = int.Parse(Console.ReadLine());
int lineEnd = 1;
int i = 1;

while (i <= number)
{
    for (int j = 1; j <= lineEnd; j++)
    {
        Console.Write(i + " ");
        i++;
        if (i > number)
        {  
            break; 
        }
    }
    Console.WriteLine();
    lineEnd++;
}
