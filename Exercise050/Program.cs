// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4      17 -> такого числа в массиве нет

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


void FindNumber(int[,] arr, int x, int y) // поиск заданного числа в массиве
{
    int temp = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == x && j == y)
                {
                    arr[i,j] = arr[x,y];
                    temp = arr[x,y];
                }
            }   
    }    
        if (temp != 0)
            Console.WriteLine($"Значение элемента массива c позицией {x+1} строки и {y+1} столбца = {temp}");
        else
            Console.WriteLine("Значение элемента массива по заданным параметрам не обранужено!");
}


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n"),
    x = GetNumberFromConsole("Введите номер строки для поиска элемента в массиве") - 1,
    y = GetNumberFromConsole("Введите номер столбца для поиска элемента в массиве") - 1;
int[,] array = InitializateArray(m,n);
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindNumber(array, x, y);

