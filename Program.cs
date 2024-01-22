int numberOfPage = int.Parse(Console.ReadLine());
int pagesReadPerHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

int totalReadingTime = numberOfPage / pagesReadPerHour;
int requeredPerDay =totalReadingTime / numberOfDays;

Console.WriteLine(requeredPerDay);