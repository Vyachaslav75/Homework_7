// Программа задает двумерный массив размером mxn заполненный 
//случайными вещественными числами от 0 до 1000
int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}

void PrintArrayDouble(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j], 8:F3} ");
        }
        Console.WriteLine();
    }
}

double GetDoubleRandom(int usRank=3)
{
    double myDouble = new Random().NextDouble();
    int rank = new Random().Next(0, usRank + 1);
    myDouble = myDouble * Math.Pow(10, rank);
    return myDouble;
}

double[,] GetArrayDouble(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = GetDoubleRandom();
        }
    }
    return result;
}

Console.Clear();
int rows = enterNumber("Введите количество строк массива:  ", "Введите целое число");
int columns = enterNumber("Введите количество столбцов массива:  ", "Введите целое число");
double[,] array = GetArrayDouble(rows, columns);
PrintArrayDouble(array);
