int numberOfPackagesOfPens = int.Parse(Console.ReadLine());
int numberOfPacketOfMarkers = int.Parse(Console.ReadLine());    
int litersOfBoardCleaner = int.Parse(Console.ReadLine());   
int disqountPercent  = int.Parse(Console.ReadLine());

double priceForPens = numberOfPackagesOfPens * 5.80;
double priceForMarker = numberOfPacketOfMarkers * 7.20;
double priceForBoardCleaner = litersOfBoardCleaner * 1.20;

double priceForAllMaterials = priceForPens + priceForMarker + priceForBoardCleaner;
;
double priceAfterDisqount = priceForAllMaterials - (priceForAllMaterials * disqountPercent /100);

Console.WriteLine(priceAfterDisqount);