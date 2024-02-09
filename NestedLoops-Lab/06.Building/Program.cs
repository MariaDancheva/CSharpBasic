int floors = int.Parse(Console.ReadLine());
int roomsPerFloor = int.Parse(Console.ReadLine());
string typeOfRoom = "";

for (int floorNumber = floors; floorNumber >= 1; floorNumber--)
{

    for (int roomNumber = 0; roomNumber < roomsPerFloor; roomNumber++)
    {
        if (floorNumber == floors)
        {
            typeOfRoom = "L";
        }
        else if (floorNumber % 2 == 0)
        {
            typeOfRoom = "O";
        }
        else
        {
            typeOfRoom = "A";
        }
        Console.Write($"{typeOfRoom}{floorNumber}{roomNumber} ");
    }
    Console.WriteLine();
    
}