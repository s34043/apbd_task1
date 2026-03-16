int[] numbers = { 2, 4, 6, 8 };

double average = CalculateAverage(numbers);
Console.WriteLine("Average = " + average);

int max = CalculateMax(numbers);
Console.WriteLine("Max = " + max);

int min = CalculateMin(numbers);
Console.WriteLine("Min = " + min);

Console.WriteLine("sup, feature-conflict branch!");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

static double CalculateAverage(int[] values)
{
    if (values.Length == 0)
    {
        return 0;
    }

    int sum = 0;

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return (double)sum / values.Length;
}

static int CalculateMax(int[] values)
{
    if (values.Length == 0)
    {
        return 0;
    }

    int max = values[0];

    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }

    return max;
}

static int CalculateMin(int[] values)
{
    if (values.Length == 0)
    {
        return 0;
    }

    int min = values[0];

    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] < min)
        {
            min = values[i];
        }
    }

    return min;
}