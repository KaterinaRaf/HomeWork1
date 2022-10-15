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

int[,] CheckArray(int a, int b)
{
    Console.WriteLine("Количество строк и количество столбцов в массиве не должно быть равным! введите еще раз: ");
    Console.WriteLine("Введите количество строк в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m == n) 
        CreateArray();
    int[,] arr = new int[m, n];
    return arr;
}

int[,] CreateArray()
{
    Console.WriteLine("Введите количество строк в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[m, n];
    if (m == n) 
        arr = CheckArray(m, n);
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

int[,] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumRow(array);
Console.WriteLine();


