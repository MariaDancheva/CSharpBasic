char lastBlock = char.Parse(Console.ReadLine());
int numberRows = int.Parse(Console.ReadLine());
int numberSeatsInEvenRow = int.Parse(Console.ReadLine());
int seatsCount = 0;
int oddSeats = numberSeatsInEvenRow + 2;
char firstSector = 'A';
for (int sector =(int)firstSector; sector <= (int)lastBlock; sector++ , numberRows++)
{
    for (int row = 1; row <= numberRows; row++)
    {
        char currentSeat = 'a';
        if (row % 2 == 0)
        {
            numberSeatsInEvenRow = oddSeats;
        }
        else 
        {
            numberSeatsInEvenRow = oddSeats - 2;
        }
        for (int seat = 1; seat <= numberSeatsInEvenRow; seat++)
        {
            Console.WriteLine($"{(char)sector}{row}{currentSeat}");
            seatsCount++;
            int current = (int)currentSeat + 1;
            currentSeat = (char)current;
        }
    }
}
Console.WriteLine(seatsCount);
