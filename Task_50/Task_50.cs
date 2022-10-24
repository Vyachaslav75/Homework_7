// Программа создает массив размером mxn, где m и n случайные числа от 2 до 10.
// Массив заполняется случайными числами от -99 до 99.
// Пользователь вводит номер строки и номер столбца.
// Если такой элемент есть, программа его выводит.
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
            Console.Write($"{inArray[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void CheckNumber(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        Console.WriteLine($"элемент в строке {row}, столбце {column} -> {array[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine($"{row}, {column} -> такого элемента в массиве нет");
    }

}


Console.Clear();
// int rows = enterNumber("Введите количество строк массива:  ", "Введите целое число");
// int columns = enterNumber("Введите количество столбцов массива:  ", "Введите целое число");
int rows = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);
int userRow = enterNumber("Введите номер строки:  ", "Введите целое число");
int userColumn = enterNumber("Введите номер столбца:  ", "Введите целое число");
int[,] array = GetArray(rows, columns);
PrintArray(array);
CheckNumber(array, userRow, userColumn);
