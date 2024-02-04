// 1. Input from the console
// - one number for length in meters * 100- double
double lenght = double.Parse(Console.ReadLine()) * 100;

// - one double number for wight * 100
double widht = double.Parse(Console.ReadLine()) * 100 - 100;

// 2. write in all the constants
// - one work place 70 * 120
int workDeskWidth = 70;
int workDeskLenght = 120;
int unUsableWorkDesksSpace = 3;

        
 double desksOnRow = lenght / workDeskLenght;
 double numberOfRows = widht / workDeskWidth;
 double desks = Math.Floor(desksOnRow);
 double rows = Math.Floor(numberOfRows);
 double workDesks = desks * rows - unUsableWorkDesksSpace;

Console.WriteLine(workDesks);

        

    


// - Calculate how many work places there are using the arw left /  (one work place)
// - Print out the result
