// 1. read from the console
// - fuelType - string
string fuelType = Console.ReadLine();
// - liters - double
double litersFuel = double.Parse(Console.ReadLine());
// - card - string
string card = Console.ReadLine();

// 2. discounted fuel
// - gasolinDiscount = 2.22 - o.18
double gasolineDiscount = 2.22 - 0.18;
// - disel = 2.33 - 0.12
double dieselDiscount = 2.33 - 0.12;
// - gas = 0.93 - 0.08
double gasDiscount = 0.93 - 0.08;

// 3. if gasoline * 2.22, 
// if card yes - liters * gasolinDiscound
// if <=25 , > 20 -> 8% discount of total, print "{крайната цена на горивото} lv."
// if > 25, 10% discount of total, print "{крайната цена на горивото} lv."
// else if no card , print "{крайната цена на горивото} lv."
if (fuelType == "Gasoline")
{
    if (card == "Yes")
    {
        double gasoline = litersFuel * gasolineDiscount;
        if (litersFuel <= 25)
        {
            if (litersFuel > 20)
            {
                double gasolineTotal = gasoline - gasoline * 0.08;
                double gasolineRounded =(double) Math.Round(gasolineTotal, 2);
                Console.WriteLine($"{gasolineRounded} lv.");
            }
            else
            {
                double gasolineRounded = (double)Math.Round(gasoline , 2);
                Console.WriteLine($"{gasolineRounded} lv.");
            }
            
        }
        else if (litersFuel > 25)
        {
            double gasolineTotal = gasoline - gasoline * 0.1;
            double gasolineRounded = (double)Math.Round(gasolineTotal, 2);
            Console.WriteLine($"{gasolineRounded} lv.");
        }

    }
    else if (card == "No")
    {
        double gasoline = litersFuel * 2.22;
        if (litersFuel <= 25)
        {
            if (litersFuel > 20)
            {
                double gasolineTotal = gasoline - gasoline * 0.08;
                double gasolineRounded = (double)Math.Round(gasolineTotal, 2);
                Console.WriteLine($"{gasolineRounded} lv.");
            }
            else
            {
                double gasolineRounded = (double)Math.Round(gasoline, 2);
                Console.WriteLine($"{gasolineRounded} lv.");
            }
        }
        else if (litersFuel > 25)
        {
            double gasolineTotal = gasoline - gasoline * 0.1;
            double gasolineRounded =(double) Math.Round(gasolineTotal, 2);
            Console.WriteLine($"{gasolineRounded} lv.");
        }

                
    }
}

// else if diesel * 2.33,if card yes liters * disel
//if <=25, >20 -> 8% discount of total, print "{крайната цена на горивото} lv."
// if > 25 - >10% discount of total, print "{крайната цена на горивото} lv."
// else if no card, print $"{0:F2}{крайната цена на горивото} lv."
if (fuelType == "Diesel")
{
    if (card == "Yes")
    {
        double diesel = litersFuel * dieselDiscount;
        if (litersFuel <= 25)
        {
            if (litersFuel > 20)
            {
                double dieselTotal = diesel - diesel * 0.08;
                double dieselRounded = (double)Math.Round(dieselTotal, 2);
                Console.WriteLine($"{dieselRounded} lv.");
            }
            else
            {
                double dieselRounded = (double)Math.Round(diesel , 2);
                Console.WriteLine($"{dieselRounded} lv.");
            }

        }
        else if (litersFuel > 25)
        {
            double dieselTotal = diesel - diesel * 0.1;
            double dieselRounded =(double) Math.Round(dieselTotal, 2);
            Console.WriteLine($"{dieselRounded} lv.");
        }

    }
    else if (card == "No")
    {
        double diesel = litersFuel * 2.33;
        if (litersFuel <= 25)
        {
            if (litersFuel > 20)
            {
                double dieselTotal = diesel - diesel * 0.08;
                double dieselRounded =(double) Math.Round(dieselTotal, 2);
                Console.WriteLine($"{dieselRounded} lv.");
            }
            else  
            {
                double dieselRounded = (double)Math.Round(diesel, 2);
                Console.WriteLine($"{dieselRounded} lv.");
            }
        }
        else if (litersFuel > 25)
        {
            double dieselTotal = diesel - diesel * 0.1;
            double dieselRounded = (double)Math.Round(dieselTotal, 2);
            Console.WriteLine($"{dieselRounded} lv.");
        }

    }
   
}


// else if gas *0.93, 
// if card yes - liters * gas
// if > 25 - >10% discount of total, print $"{0:F2}{крайната цена на горивото} lv."
// else if no card, print  $"{0:F2}{крайната цена на горивото} lv."
if (fuelType == "Gas")
{
    if (card == "Yes")
    {
        double gas = litersFuel * gasDiscount;
        if (litersFuel <= 25)
        {
            if (litersFuel > 20)
            {
                double gasTotal = gas - gas * 0.08;
                double gasRounded =(double) Math.Round(gasTotal, 2);
                Console.WriteLine($"{gasRounded} lv.");
            }
            else
            {
                double gasRounded = (double)Math.Round(gas);
                Console.WriteLine($"{gasRounded} lv.");
            }

        }
        else if (litersFuel > 25)
        {
            double gasTotal = gas - gas * 0.1;
            double gasRounded =(double) Math.Round(gasTotal , 2);
            Console.WriteLine($"{gasRounded} lv.");
        }

    }
    else if (card == "No")
    {
        double gas = litersFuel * 0.93;
        if (litersFuel <= 25)
        {
            if (litersFuel > 20)
            {
                double gasTotal = gas - gas * 0.08;
                double gasRounded = (double)Math.Round(gasTotal, 2);
                Console.WriteLine($"{gasRounded} lv.");
            }
            else
            {
                double gasTotal = (double)Math.Round(gas, 2);
                Console.WriteLine($"{gasTotal} lv.");
            }
        }
        else if (litersFuel > 25)
        {
            double gasTotal = gas - gas * 0.1;
            double gasRounded =(double) Math.Round(gasTotal, 2);
            Console.WriteLine($"{gasRounded} lv.");
        }

    }
}

