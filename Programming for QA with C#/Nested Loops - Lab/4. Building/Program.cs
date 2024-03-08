int countOfFloors = int.Parse(Console.ReadLine());
int estatesPerFloor = int.Parse(Console.ReadLine());

for (int f = countOfFloors; f >= 1; f--)
{
    for (int e = 0; e < estatesPerFloor; e++)
    {
        if (f == countOfFloors)
        {
            Console.Write($"L{f}{e} ");
        }
        else if (f % 2 == 0)
        {
            Console.Write($"O{f}{e} ");
        }
        else
        {
            {
                Console.Write($"A{f}{e} ");
            }
        }
    }
    Console.WriteLine();
}