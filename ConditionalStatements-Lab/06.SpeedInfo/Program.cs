//1.input double number from the console
double speed = double.Parse(Console.ReadLine());

//2. if speed <= 10 print Slow
if (speed <= 10)
    Console.WriteLine("slow");
//3. else if speed <= 50 also speed >10 => print average
else if (speed <= 50)
{
    if (speed > 10)
        Console.WriteLine("average");
}
//4. else if speed <=150 also speed >50 => print fast
else if (speed <= 150)
{
    if (speed > 50)
        Console.WriteLine("fast");
}
//5. else if speed <=1000 also speed > 150 => print ultraa fast
else if (speed <= 1000)
{
    if (speed > 150)
        Console.WriteLine("ultra fast");
}
//6. else print extreamly fast
else
    Console.WriteLine("extremely fast");
