int upperBorderFirstNum = int.Parse(Console.ReadLine());
int upperBorderSecondNum = int.Parse(Console.ReadLine());
int upperBorderThirdNum = int.Parse(Console.ReadLine());

for (int first = 2; first <= upperBorderFirstNum; first += 2)
{
    for (int second = 2; second <= upperBorderSecondNum; second++)
    {
        for (int third = 2; third <= upperBorderThirdNum; third += 2)
        {
               if (second == 2 || second == 3 || second == 5 || second == 7)
                Console.WriteLine($"{first} {second} {third}");
            
        }
    }
}
