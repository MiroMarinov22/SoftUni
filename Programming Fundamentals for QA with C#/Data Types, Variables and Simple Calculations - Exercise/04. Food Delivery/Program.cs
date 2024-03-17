int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double chickenPrice = chickenMenu * 10.35;
double fishPrice = fishMenu * 12.40;
double vegetarianPrice = vegetarianMenu * 8.15;
double totalCostOfMenus = chickenPrice + fishPrice + vegetarianPrice;
double desertPrice = totalCostOfMenus * 0.2;
double totalOrderPrice = totalCostOfMenus + desertPrice + 2.50;

Console.WriteLine(totalOrderPrice);
