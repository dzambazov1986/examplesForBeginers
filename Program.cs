double tomatoePrice = double.Parse(Console.ReadLine());
double tomatoeQuanty = double.Parse(Console.ReadLine()); 
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuanty = double.Parse(Console.ReadLine());

double tomatoes = tomatoePrice * tomatoeQuanty;
double cucumber = cucumberPrice * cucumberQuanty;   

double totalCost = tomatoes + cucumber;

Console.WriteLine($"{totalCost:F2}");

