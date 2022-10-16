// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int[,] MultiMatrix(int[,] arr1, int[,] arr2, int[,] resultArray)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
            resultArray[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
        
    }
    return resultArray;
}



//КОД ОСНОВНОЙ ПРОГРАММЫ
Console.WriteLine("Введите размерность квадратной матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array1 = InitializateArray(m,m);
int[,] array2 = InitializateArray(m,m);
int[,] array3 = InitializateArray(m,m);
FillArray(array1);
Console.WriteLine();
PrintArray(array1);
FillArray(array2);
PrintArray(array2);
int[,] array = MultiMatrix(array1, array2, array3);
Console.WriteLine("Результат перемножения двух квадратных матриц: ");
PrintArray(array);