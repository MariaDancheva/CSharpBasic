// 1. Console input daysOff
using System.Text;

int daysOff = int.Parse(Console.ReadLine());
// 2. Playing time
// - workDaysPlayTime = 63 min
int workDaysPlayTime = 63;
// - offDaysPlayTime = 127 min
int offDaysPlayTime = 127;
// - workdays = 365 - daysOff
int workDays = 365 - daysOff;
// - totalPlayTime = workdays * workdaysPlayTime + offDaysPlayTime * daysOff
int totalPlayTime = workDays * workDaysPlayTime + offDaysPlayTime * daysOff;
// 3. Print if totalPlayTime > 30 000
// - bonusHours = (totalPlayTime - 30 000) / 60
// - bonusMinutes = (totalPlayTime - 30 000) % 60
// - print “Tom will run away”
// - print $“{bonusHours} hours and {bonusMinutes} minutes more for play”
if (totalPlayTime > 30000)
{
    double bonusHours = (totalPlayTime - 30000) / 60;
    double bonusMin = (totalPlayTime - 30000) % 60;
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{bonusHours} hours and {bonusMin} minutes more for play");

}
// 4. else if totalPlayTime < 30 000
// - bonusHoursSleep = (30 000 - totalPlayTime) / 60)
// - BonusMinSleep = (30 000 - totalPlayTime) % 60
// - print “Tom sleeps well”
// - print $“{bonusHours} hours and {bonusMinSleep} minutes less for play”
else if (totalPlayTime < 30000)
{
    double bonusHoursSleep = (30000 - totalPlayTime) / 60;
    double bonusMinSleep = (30000 - totalPlayTime) % 60;
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{bonusHoursSleep} hours and {bonusMinSleep} minutes less for play");
}
