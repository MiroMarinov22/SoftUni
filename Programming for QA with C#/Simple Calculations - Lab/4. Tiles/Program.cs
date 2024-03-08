double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = (bathroomWidth * bathroomHeight);
double bathroomAreaWithSurplus = bathroomArea + (bathroomArea * 0.1);
double tileArea = tileWidth * tileHeight;
double tilesNeeded = bathroomAreaWithSurplus / tileArea;
int neededTiles = (int)Math.Round(tilesNeeded);

Console.WriteLine(neededTiles);