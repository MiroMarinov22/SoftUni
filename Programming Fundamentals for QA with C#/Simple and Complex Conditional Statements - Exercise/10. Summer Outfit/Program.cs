﻿int temperature = int.Parse(Console.ReadLine());
string timeOfDay =  Console.ReadLine();
string clothing = "";
string shoes = "";

if (timeOfDay == "Morning")
{
    if (temperature >= 10 && temperature <= 18)
    {
        clothing = "Sweatshirt";
        shoes = "Sneakers";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
    else if (temperature > 18 && temperature <= 24)
    {
        clothing = "Shirt";
        shoes = "Moccasins";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
    else if (temperature >= 25)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
}
else if (timeOfDay == "Afternoon")
{
    if (temperature >= 10 && temperature <= 18)
    {
        clothing = "Shirt";
        shoes = "Moccasins";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
    else if (temperature > 18 && temperature <= 24)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
    else if (temperature >= 25)
    {
        clothing = "Swim Suit";
        shoes = "Barefoot";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
}
else if (timeOfDay == "Evening")
{
    if (temperature >= 10 && temperature <= 18)
    {
        clothing = "Shirt";
        shoes = "Moccasins";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
    else if (temperature > 18 && temperature <= 24)
    {
        clothing = "Shirt";
        shoes = "Moccasins";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
    else if (temperature >= 25)
    {
        clothing = "Shirt";
        shoes = "Moccasins";

        Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
    }
}