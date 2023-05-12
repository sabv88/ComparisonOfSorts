using System.Diagnostics;
using static kursa4.CreateArraysToSort;
using static kursa4.Sorts;

Console.WriteLine("All random mas Insertion sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i*=10)
{
    var masAllRandom = AllRandom(i, 0, 10000);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = InsertionSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}

Console.WriteLine();
Console.WriteLine("All random mas Shell sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = AllRandom(i, 0, 10000);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = ShellSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}

Console.WriteLine();
Console.WriteLine("Sorted mas Insertion sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = Sorted(i);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = InsertionSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}

Console.WriteLine();
Console.WriteLine("Sorted mas Shell sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = Sorted(i);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = ShellSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}

Console.WriteLine();
Console.WriteLine("ReverseSorted mas Insertion sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = ReverseSorted(i);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = InsertionSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}

Console.WriteLine();
Console.WriteLine("ReverseSorted mas Shell sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = ReverseSorted(i);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = ShellSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}
Console.WriteLine();
Console.WriteLine("ParticalSorted mas Insertion sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = ParticalSorted(i, 0, 10000);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = InsertionSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}

Console.WriteLine();
Console.WriteLine("ParticalSorted mas Shell sort");
Console.WriteLine("Array size  | Execution time(ms) | Swap amount");

for (int i = 1000; i < 1_000_000; i *= 10)
{
    var masAllRandom = ParticalSorted(i, 0, 10000);
    Stopwatch sortTime = Stopwatch.StartNew();
    uint count = ShellSort(masAllRandom);
    sortTime.Stop();
    Console.WriteLine("{0,6}      | {1,5}              | {2}", i, sortTime.ElapsedMilliseconds, count);
}