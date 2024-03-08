string drinkName = Console.ReadLine();
string extra = Console.ReadLine();
double price = 0;

if (drinkName == "coffee" & extra == "sugar")
    price = 1.40;
else if (drinkName == "tea" & extra == "sugar")
    price = 1.00;
else if (drinkName == "coffee" & extra == "no")
    price = 1.00;
else if (drinkName == "tea" & extra == "no")
    price = 0.60;

Console.WriteLine($"Final price: ${price:F2}");

