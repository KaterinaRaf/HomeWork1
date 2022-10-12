// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void FillArray(int[] arr)
{
    Console.WriteLine($"Введите последовательно элеметы массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountPositivNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}


Console.WriteLine("Введите количество элеметов (объем) массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(array);
PrintArray(array);
Console.WriteLine("Количество положительных элементов равно " + CountPositivNumbers(array));
Console.WriteLine();
