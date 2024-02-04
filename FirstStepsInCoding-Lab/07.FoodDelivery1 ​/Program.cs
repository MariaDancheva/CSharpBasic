// ! Input from console
int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegeterianMenu = int.Parse(Console.ReadLine());

//2. Prie per menu
double chickenPrice = chickenMenu * 10.35;
double fishPrice = fishMenu * 12.4;
double veganPrice = vegeterianMenu * 8.15;

 //3. Price total per menu + decert 
double food = chickenPrice + fishPrice + veganPrice;
double decert = food * 0.2;
double delivery = 2.50;
//4. Toal
double total = food + decert + delivery;
//5. Write outpu
Console.WriteLine(total);
