string typeOfFigure = Console.ReadLine();
double area = 0;

if (typeOfFigure == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (typeOfFigure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    area = width * length;
}
else if (typeOfFigure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * radius * radius;
}

Console.WriteLine($"{area:F2}");