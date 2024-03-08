string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double totalPrice = GetPrice(product, quantity);
Console.WriteLine($"{totalPrice:F2}");
static double GetPrice(string prod, int quant)
{
    double productPrice = 0;

    if (prod == "coffee")
    {
        productPrice = 1.50;
    }

    else if (prod == "water")
    {
        productPrice = 1.00;
    }

    else if (prod == "coke")
    {
        productPrice = 1.40;
    }

    else if (prod == "snacks")
    {
        productPrice = 2.00;
    }

    return productPrice * quant;
}