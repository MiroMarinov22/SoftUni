string typeOfMovie = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeatsPerRow = int.Parse(Console.ReadLine());
double price = 0;

if (typeOfMovie == "Premiere")
{
    price = 12.00;
}
else if (typeOfMovie == "Normal")
{
    price = 7.50; 
}
else if (typeOfMovie == "Discount")
{
    price = 5.00;
}

int totalCountofSeats = countOfRows * countOfSeatsPerRow;
double totalPrice = totalCountofSeats * price;

Console.WriteLine($"{totalPrice:F2}");