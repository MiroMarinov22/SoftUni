double radiusOfACircle = double.Parse(Console.ReadLine());

double area = radiusOfACircle * radiusOfACircle * Math.PI;
double perimeter = 2 * Math.PI * radiusOfACircle;

Console.WriteLine($"Area = {area:F2}");
Console.WriteLine($"Perimeter = {perimeter:F2}");