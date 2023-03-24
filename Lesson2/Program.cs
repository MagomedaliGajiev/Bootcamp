using static ArrayCreator;
using static ArrayMath;
using System.Diagnostics;

Console.Clear();

int[] array = 1_100_000.Create()
                .Fill(1, 10);
// array.ConverToStringAndPrintToTerminal();

int max;
int m = 100_000;

Stopwatch sw = new Stopwatch();
sw.Start();

max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");
// Console.WriteLine(array.ConverToString());


