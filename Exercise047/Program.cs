// Задача 47. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9

double GetNumberFromConsole(string text) //пользовательский ввод данных
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double GetRandomValue(double i, double j)
{
    return new Random().Next(-50, 50);
}


void FillArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) 
    {
        for(int j = 0; j < arr.GetLength(1); j++) 
        {
            arr[i,j] = GetRandomValue(i, j);
        }
    }
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[Math.Round(i,2),Math.Round(j,2)] + " ");
        }
        Console.WriteLine();
    }
}

double[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
double m = GetNumberFromConsole("Введите размерность массива m"),
       n = GetNumberFromConsole("Введите размерность массива n");
double[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
