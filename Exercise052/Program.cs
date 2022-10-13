// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetNumberFromConsole(string text) //пользовательский ввод данных
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int i, int j)
{
    return new Random().Next(0, 50);
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
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}


void ArithmeticMeanCol(int[,] arr) 
{
    double mean = 0;
    int sum = 0;
    int count = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            while (j < arr.GetLength(1))
            {
                sum += arr[0,j];
                count++;
                j++;
            }  
            mean = sum / count;
        }   
    }    
    
        Console.WriteLine($"Значение ареднего арифметического каждого столбца равно {mean}");
}


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
ArithmeticMeanCol(array);