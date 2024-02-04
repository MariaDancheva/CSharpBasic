int listInThisBook = int.Parse(Console.ReadLine());
int readInHour = int.Parse(Console.ReadLine());
int finishInDays = int.Parse(Console.ReadLine());

int totalReadingTime = listInThisBook / readInHour;
int timeADay = totalReadingTime / finishInDays;
Console.WriteLine(timeADay);
