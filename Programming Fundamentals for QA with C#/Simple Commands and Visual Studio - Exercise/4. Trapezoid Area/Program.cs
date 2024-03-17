int firstSide = int.Parse(Console.ReadLine());
int secondSide = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int trapezoidsArea = (firstSide + secondSide) / 2 * height;

Console.WriteLine(trapezoidsArea);
