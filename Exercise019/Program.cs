// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. 
//14212 -> нет/ 12821 -> да / 23432 -> да

int GetNumber() // метод для ввода числа
{
    int number = 0;
    while (number < 9999 || number > 99999)
{
    Console.WriteLine("Введите пятизначное число");
    number = Convert.ToInt32(Console.ReadLine());
}
return number;
}

void CheckPalindrom(int number) // метод для анализа зеркальности     
{
    int i1 = number / 10000;
    int i2 = (number / 1000) % 10;
    int i4 = (number / 10) % 10;
    int i5 = number % 10;
        
    if ((i1 == i5) && (i2 == i4))
    {
        Console.WriteLine(number + " - данное число палиндром!");
    }
    else
    {
    Console.WriteLine(number + " - данное число палиндром!");
    } 
}

int number = GetNumber();
CheckPalindrom(number);
