int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
string status ="" ;

if (hour >= 10 && hour < 18)
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
        status = "open";
    else
        status = "closed";
}
else
    status = "closed";

Console.WriteLine(status);
