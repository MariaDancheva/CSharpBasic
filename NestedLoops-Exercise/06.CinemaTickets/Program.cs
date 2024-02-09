using System.Net.Sockets;

string filmName = Console.ReadLine();
int totalTicketsSold = 0;
int studentCount = 0;
int standartCount = 0;
int kidsCOunt = 0;

while (filmName != "Finish")
{
    int seats = int.Parse(Console.ReadLine());
    int ticketsSold = 0;
    while (ticketsSold != seats)
    {
        string ticketType = Console.ReadLine();
       
        switch (ticketType)
        {
            case "student":
                studentCount++;
                ticketsSold++;
                break;
            case "standard":
                ticketsSold++;
                standartCount++;
                break;
            case "kid":
                ticketsSold++;
                kidsCOunt++;
                break;
            case "End":
                break;
        }
        if (ticketType == "End")
        {
            totalTicketsSold += ticketsSold;
            Console.WriteLine($"{filmName} - {(double)ticketsSold / seats * 100:F2}% full.");
            break;
        }
    }
    if (ticketsSold == seats)
    {
        totalTicketsSold += ticketsSold;
        Console.WriteLine($"{filmName} - {(double)ticketsSold / seats * 100:F2}% full.");
    }
    filmName = Console.ReadLine();
}
Console.WriteLine($"Total tickets: {totalTicketsSold}");
Console.WriteLine($"{(double)studentCount/totalTicketsSold * 100:F2}% student tickets.");
Console.WriteLine($"{(double)standartCount/totalTicketsSold * 100:F2}% standard tickets.");
Console.WriteLine($"{(double)kidsCOunt/totalTicketsSold * 100:F2}% kids tickets.");