int extent = int.Parse(Console.ReadLine());
//int number = 1;
int difference = 0;
int left = 0;
int right = 0;


for (int i = 1; i <= extent ; i += 1)
{
    int num = int.Parse(Console.ReadLine());
    //number = number * 2 ;
        left += num;
}
for (int a = 1; a <= extent; a++)
{
    int rightNum = int.Parse(Console.ReadLine());
    right += rightNum;
}

difference = left - right;
if (difference == 0)
{
    Console.WriteLine($"Yes, sum = {left}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(difference)}");

}