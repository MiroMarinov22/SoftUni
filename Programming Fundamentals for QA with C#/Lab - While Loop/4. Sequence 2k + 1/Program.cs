int number = int.Parse(Console.ReadLine());
int sum = 1;

while (sum < number)
{
    Console.WriteLine(sum);
    sum = 2 * sum + 1;
}

