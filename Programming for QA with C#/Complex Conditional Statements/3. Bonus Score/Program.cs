int point = int.Parse(Console.ReadLine());  

if (point >= 0 && point <= 3)
{
    point += 5;
    Console.WriteLine(point);
}

else if (point >= 4 && point <= 6)
{
    point += 15;
    Console.WriteLine(point);
}

else if (point >= 6 && point <= 9)
{
    point += 20;
    Console.WriteLine(point);
}