int numberOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int readingTime = numberOfPages / pagesPerHour;
int hoursPerDay = readingTime / days;

Console.WriteLine(hoursPerDay);