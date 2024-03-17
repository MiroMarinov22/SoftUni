string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());
int pricePerNight = 0;
double discount = 0;
double totalExpenses = 0;
double totalExpensesWithDiscount = 0;

if (season == "Spring")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 30;
        discount = 0.2;
        totalExpenses = (countOfDays * pricePerNight);
        totalExpensesWithDiscount = totalExpenses - (totalExpenses * discount);
        Console.WriteLine($"{totalExpensesWithDiscount:F2}");
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 10;
        discount = 0.2;
        totalExpenses = (countOfDays * pricePerNight);
        totalExpensesWithDiscount = totalExpenses - (totalExpenses * discount);
        Console.WriteLine($"{totalExpensesWithDiscount:F2}");
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 50;
        totalExpenses = (countOfDays * pricePerNight);
        Console.WriteLine($"{totalExpenses:F2}");
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 30;
        totalExpenses = (countOfDays * pricePerNight);
        Console.WriteLine($"{totalExpenses:F2}");
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 20;
        discount = 0.3;
        totalExpenses = (countOfDays * pricePerNight);
        totalExpensesWithDiscount = totalExpenses - (totalExpenses * discount);
        Console.WriteLine($"{totalExpensesWithDiscount:F2}");
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 15;
        discount = 0.3;
        totalExpenses = (countOfDays * pricePerNight);
        totalExpensesWithDiscount = totalExpenses - (totalExpenses * discount);
        Console.WriteLine($"{totalExpensesWithDiscount:F2}");
    }
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        pricePerNight = 40;
        discount = 0.1;
        totalExpenses = (countOfDays * pricePerNight);
        totalExpensesWithDiscount = totalExpenses - (totalExpenses * discount);
        Console.WriteLine($"{totalExpensesWithDiscount:F2}");
    }
    else if (accommodationType == "Camping")
    {
        pricePerNight = 10;
        discount = 0.1;
        totalExpenses = (countOfDays * pricePerNight);
        totalExpensesWithDiscount = totalExpenses - (totalExpenses * discount);
        Console.WriteLine($"{totalExpensesWithDiscount:F2}");
    }
}
