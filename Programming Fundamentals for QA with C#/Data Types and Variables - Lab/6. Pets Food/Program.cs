int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double dogFoodExpenses = dogFood * 2.50;
double catFoodExpenses = catFood * 4.00;
double allExpenses = dogFoodExpenses + catFoodExpenses;

Console.WriteLine($"{allExpenses:F2} lv.");