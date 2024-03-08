Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

int[] arr = new[] { 1, 2, 3, 4, 5 };

Console.WriteLine(GetAvg(arr));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return (double) sum / arr.Length;
}