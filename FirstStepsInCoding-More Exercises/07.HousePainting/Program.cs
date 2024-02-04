//1. Input from the console
// - hight of the house - double
double houseHight = double.Parse(Console.ReadLine());
// - lenght of the house - double
double houseLenght = double.Parse(Console.ReadLine());
// - hight of the triangle side of the roof - double
double roofHight = double.Parse(Console.ReadLine());

//2. Find the area
// * back and front walls
//  -back and front = hight * hight + hight * hight - 1.2 * 2
double backAndFrontWalls = 2 * (houseHight * houseHight) - 1.2 * 2;
// * side wals
//  - (hight * lenght + hight * lenght) - (1.5 *1.5) * 2
double sideWalls = (houseHight * houseLenght) * 2 - (1.5 * 1.5) * 2;
// total color green = back and front + side wals
double greenPaint = (backAndFrontWalls + sideWalls) / 3.4;
// * roof
//  - (hight of the house * hight roof * 0.5) * 2
double roofTriangle = (houseHight * roofHight * 0.5) * 2;
//  - roof sides = side wals + (1.5 * 1.5) * 2
double roofSides = sideWalls + (1.5 * 1.5) * 2;
//  - red color = roof triangle + roof sides
double redPaint = (roofTriangle + roofSides) / 4.3;
//3. Print output
// - print green
Console.WriteLine("{0:F2}", greenPaint);
// - print red
Console.WriteLine("{0:F2}", redPaint);

