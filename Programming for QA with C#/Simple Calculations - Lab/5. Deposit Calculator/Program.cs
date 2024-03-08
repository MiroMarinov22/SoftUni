double depositedAmount = double.Parse(Console.ReadLine());
int termOfTheDeposit = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double accumulatedInterest = (depositedAmount * annualInterestRate) / 100;
double interestPerMonth = accumulatedInterest / 12;
double totalAmount = depositedAmount + (termOfTheDeposit * interestPerMonth);

Console.WriteLine(totalAmount);
