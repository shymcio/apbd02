﻿Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

int[] arr = new[] { 1, 2, 3, 4, 5 };

Console.WriteLine(GetAvg(arr));
Console.WriteLine(GetMax(arr));

static double GetAvg(int[] arr)
{
    int sum = 0;
    foreach (var number in arr)
    {
        sum += number;
    }

    return (double) sum / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = 0;
    foreach (var num in arr)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}