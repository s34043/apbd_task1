int[] numbers = { 2, 4, 6, 8 };

double average = CalculateAverage(numbers);
Console.WriteLine("Average = " + average);

Console.WriteLine("sup, apbd");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

static double CalculateAverage(int[] values)
{
    int sum = 0;

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return (double)sum / values.Length;
}