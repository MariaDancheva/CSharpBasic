//1. Input from Console
// -Необходимо количество найлон (в кв.м.) - int + 2
int nylon = int.Parse(Console.ReadLine()) + 2;
// -Необходимо количество боя - int
int color = int.Parse(Console.ReadLine());
// -Количество разредител - int
int delusion = int.Parse(Console.ReadLine());
// - Часовете
int hoursOfWork = int.Parse(Console.ReadLine());

// 2. Calculating costs for materials
// -nylon = input * 1.50
double priceNylon = nylon * 1.5;
// -color = (input * 0.1 + input) *14.50
double priceColor = (color * 0.1 + color) * 14.5;
// -delusion = input * 5.0
double priceDelucion = delusion * 5.0;
// -bag = 0.4
double bag = 0.40;
// - materials= ( nylon + color + delusion + bag)
double materialsPrice = priceNylon + priceColor + priceDelucion + bag;

// 3. Workers pay = (materials * 0.3) * hource
double workersPay = (materialsPrice * 0.3) * hoursOfWork;

// 4. Total money spend
double total = materialsPrice + workersPay;

// 5. Printing output
Console.WriteLine(total);
