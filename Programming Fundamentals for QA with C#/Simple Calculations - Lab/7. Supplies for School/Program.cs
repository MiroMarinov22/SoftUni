int packagesOfPens = int.Parse(Console.ReadLine());
int packagesOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double priceOfPackagesOfPens = packagesOfPens * 5.80;
double priceOfMarkerPackages = packagesOfMarkers * 7.20;
double priceOfBoardCleaner = litersOfBoardCleaner * 1.20;
double priceOfAllMaterials = priceOfPackagesOfPens + priceOfMarkerPackages + priceOfBoardCleaner;
double calculatedDiscount = discountPercentage / 100.0;
double priceAfterDiscount = priceOfAllMaterials - (priceOfAllMaterials * calculatedDiscount);

Console.WriteLine(priceAfterDiscount);
