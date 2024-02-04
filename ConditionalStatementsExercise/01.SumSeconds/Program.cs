//1. input from the console
// - first athleteSecs - int
int athletheOne = int.Parse(Console.ReadLine());
// - second athleteSecs - int
int athletheTwo = int.Parse(Console.ReadLine());
// - thirdAthleteSeconds - int
int athleteTree = int.Parse(Console.ReadLine());
//2. calculate the sum
// - int sum = firstAthleteTime + secondathleteTime + thirdAthleteTime
int timeTotal = athletheOne + athletheTwo + athleteTree;
// - int min = sum / 60;
int minutes = timeTotal / 60;
// - int secs = sum % 60;
int seconds = timeTotal % 60;
// 3. Priint
// -  if secs < 10 , print $"{min}:0{secs}"
if (seconds<10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
// - else print $"{min}:{secs}"
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}