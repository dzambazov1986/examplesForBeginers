double W = double.Parse(Console.ReadLine());
double H = double.Parse(Console.ReadLine());
double wT = double.Parse(Console.ReadLine());   
double hT = double.Parse(Console.ReadLine());

double bathroomArea = W * H;
double addSurplus = bathroomArea * 0.1;
double totalBatharea = bathroomArea + addSurplus;
double tillArea = wT * hT;
double tilesNeeded = totalBatharea/tillArea;

Console.WriteLine($"{tilesNeeded:F0}");