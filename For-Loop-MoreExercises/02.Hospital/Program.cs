int period = int.Parse(Console.ReadLine());
int doctors = 7;
int treatedPatients = 0;
int unTreatedPatients = 0;

for (int i = 1; i <= period; i++)
{

    int patients = int.Parse(Console.ReadLine());
    if (i % 3 == 0 && treatedPatients < unTreatedPatients)
        ++doctors;

    if (patients <= doctors)
        treatedPatients += patients;
    else
    {
        unTreatedPatients += patients - doctors;
        treatedPatients += doctors;
    }

}
Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {unTreatedPatients}.");