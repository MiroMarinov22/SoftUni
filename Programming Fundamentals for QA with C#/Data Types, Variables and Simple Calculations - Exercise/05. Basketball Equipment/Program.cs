int annualBasketballTrainingFee = int.Parse(Console.ReadLine());

double sneakersPrice = annualBasketballTrainingFee - (annualBasketballTrainingFee * 0.4);
double basketballTeamPrice = sneakersPrice - (sneakersPrice * 0.2);
double basketballPrice = basketballTeamPrice * 0.25;
double basketballAccessoriesPrice = basketballPrice * 0.2;
double totalPrice = annualBasketballTrainingFee + sneakersPrice + basketballTeamPrice + basketballPrice + basketballAccessoriesPrice;

Console.WriteLine(totalPrice);
