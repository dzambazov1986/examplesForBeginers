double depositAmount = double.Parse(Console.ReadLine());
int depositInMounth = int.Parse(Console.ReadLine());  
double interestRate = double.Parse(Console.ReadLine());

double accumulatedInterest = depositAmount * interestRate / 100;
double interestForMonth = accumulatedInterest / 12;
double totalAmount = depositAmount + depositInMounth * interestForMonth;

Console.WriteLine($"{totalAmount:F2}");