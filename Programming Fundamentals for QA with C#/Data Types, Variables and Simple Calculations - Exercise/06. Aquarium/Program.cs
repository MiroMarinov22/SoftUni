int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = int.Parse(Console.ReadLine());

int aquariumVolume = length * width * height;
double volumeInLiters = (double)aquariumVolume / 1000;
double space = percentage / 100;
double requiredLiters = volumeInLiters * (1 - space);

Console.WriteLine($"{requiredLiters:F2}");