// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. 
//14212 -> нет/ 12821 -> да / 23432 -> да

int GetNumber() // метод для ввода числа
{
    Console.WriteLine("Введите 5-ти значное число!");
    return Convert.ToInt32(Console.ReadLine());
}


int CreateArray(int[] Num)    // преобразование введеного числа в массив
{
  int array[5];
  int number;
for (int i = 4; i >= 0; i--) 
    {
    array[i] = number % 10;
    number /= 10;
    }
}


int GetPalindrom(int[] pal) // метод для анализа зеркальности     
{
    if (pal[0] == pal[4] && pal[1] == pal[3]) // логическое И
    return 1; 
    else
    return 0; 
}

Num = GetNumber(Num);

int res = GetPalindrom(int[] Num);
   if (res = 1)
   {
     Console.WriteLine(Num + " - данное число палиндром!");
   }
   esle
   Console.WriteLine(Num + " - данное число НЕ палиндром!");
   }
