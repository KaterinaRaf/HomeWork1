// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArrayUser(int[] arr)  //заполнение массива пользователем
{
    Console.WriteLine("Введите число для массива, согласно введеному объему массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void FillArray(int[] arr)  //заполнение массива рандомом
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000,1000);
    }
}

void PrintArray(int[] arr)   //вывод на экран массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.WriteLine("Введите количество элеметов (объем) массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
 //int[] array = new int[8];   // задавание массива с опред. длинной [8]

 FillArrayUser(array);
 PrintArray(array);
 Console.WriteLine("Массив введенный пользователем");

 FillArray(array);
 PrintArray(array);
 Console.WriteLine("Массив из рандомных чисел");
