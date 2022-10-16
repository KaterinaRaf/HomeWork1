// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей 
//суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

(int, int) GetNumberFromConsole()
{
    Console.WriteLine("Введите размерность массива");
    return (Convert.ToInt32(Console.ReadLine()),
            Convert.ToInt32(Console.ReadLine()));
}

(int, int) CheckArray(int m, int n)
{
    while (m == n)
        {
        Console.WriteLine("Количество строк и количество столбцов в массиве не должно быть равным! введите еще раз: ");
        var size = GetNumberFromConsole();
        m = size.Item1;
        n = size.Item2;
        }
    return (m,n);
}

int[,] CreateArray(int m, int n)
{
    int[,] arr = new int[m, n];
    return arr;
}

int GetRandomValue(int i, int j)
{
    return new Random().Next(0, 10);
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(i, j);
        }
    }
    Console.WriteLine();
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumRow(int[,] arr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minRow += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        sumRow += arr[i, j];

        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Минимальная сумма элементов {minRow} находится в строке # {minSumRow + 1}");
}



//КОД ОСНОВНОЙ ПРОГРАММЫ
var size = GetNumberFromConsole();
int m = size.Item1,
    n = size.Item2;
var check = CheckArray(m, n);
m = check.Item1;
n = check.Item2;
int[,] array = CreateArray(m, n);
FillArray(array);
PrintArray(array);
MinSumRow(array);
Console.WriteLine();