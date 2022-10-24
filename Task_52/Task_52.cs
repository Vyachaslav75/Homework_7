// Программа создает массив размером mxn, где m и n случайные числа от 2 до 10.
// Массив заполняется случайными числами от -99 до 99.
// Программа выводит среднее арифметическое каждого столбца.
int[,] GetArray(int m, int n, int minValue = -99, int maxValue = 99)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j],8} ");
        }
        Console.WriteLine();
    }
}

double[] AverageArray(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average[i] += array[j, i];
        }
        average[i] = (double)average[i] / array.GetLength(0);
    }
    return average;
}


void PrintArrayDouble(double[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i],8:F3} ");
    }
}

Console.Clear();
int rows = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);
int[,] array = GetArray(rows, columns);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(AverageArray(array));
