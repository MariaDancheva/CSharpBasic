//1. Input from Console
int lenght = int.Parse(Console.ReadLine());
int widgh = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double persent = double.Parse(Console.ReadLine());

//2. Calculate v = length * weght * height
int v = lenght * widgh * height;
double capacityLiters = v * 0.001;
//3. Sand = 
double sand = persent / 100;

//4. Capacity
double capacity = capacityLiters * ( 1 - sand);

//5. Print output
Console.WriteLine(capacity);
