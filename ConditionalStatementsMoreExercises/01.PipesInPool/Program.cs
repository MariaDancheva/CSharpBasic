// 1. Input from hte console
// - capacity of the pool - int
int capacity = int.Parse(Console.ReadLine());
// - first pipe debit per hour- int
int firstPipe = int.Parse(Console.ReadLine());
// - second pipe debit per hour - int
int secondPipe = int.Parse(Console.ReadLine());
// - hours the worker is gone - double
double hours = double.Parse(Console.ReadLine());

// 2. Calculate how much water is in the pool
// - first pipe = first pipe debit * hours
double firstPipeLiters = firstPipe * hours;
// - second pipe = second pipe * hours
double secondPipeLiters = secondPipe * hours;
// - total water in the pool = first pipe + second pipe
double totalLeters = firstPipeLiters + secondPipeLiters;
// 3. Print
// if total <= capacity {persent full total / 100 pipe1Persent = (first pipe / total) *100}
// pipe2Persent = second pipe / total * 100 persentFull = (capacity / total) * 100;
// print "The pool is {persentFull}% full. Pipe 1: {pipe1Persent}%. Pipe 2: {pipe2Persent} %."
if (totalLeters <= capacity)
{
    double persentFull = (totalLeters / capacity) * 100;
    double firstPipePersents = (firstPipeLiters / totalLeters) * 100;
    double secondPipePersents = (secondPipeLiters / totalLeters) * 100;
    Console.WriteLine($"The pool is {persentFull} full. Pipe 1: {firstPipePersents} %. Pipe 2: {secondPipePersents} %.");
}
// else if total > capacity , overflowLiters = total - capacity,
// print "For {hours} hours the pool overflows with {overflow} liters."
else if (totalLeters > capacity)
{
    double overflowLiters = totalLeters - capacity;
    Console.WriteLine($"For {hours} hours the pool overflows with {overflowLiters} liters.");
}
