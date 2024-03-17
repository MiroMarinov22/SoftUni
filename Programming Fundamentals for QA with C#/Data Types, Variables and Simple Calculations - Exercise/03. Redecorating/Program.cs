int nylonAmount = int.Parse(Console.ReadLine());
int paintAmount = int.Parse(Console.ReadLine());
int thinnerQuantity = int.Parse(Console.ReadLine());
int hoursNeededForWork = int.Parse(Console.ReadLine());
double amountOfBags = 0.40;

double nylon = (nylonAmount + 2) * 1.50;
double paint = (paintAmount + (paintAmount * 0.1)) * 14.50;
double thinner = thinnerQuantity * 5.00;
double totalAmountOfMaterials = nylon + paint + thinner + amountOfBags;
double amountForCraftsmen = (totalAmountOfMaterials * 0.3) * hoursNeededForWork;
double totalAmount = totalAmountOfMaterials + amountForCraftsmen;

Console.WriteLine(totalAmount);