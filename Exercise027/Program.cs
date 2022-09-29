// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11     82 -> 10     9012 -> 12

int GetNumber() // Ввод числа
{
            Console.WriteLine("Введите число: ");
      return Convert.ToInt32(Console.ReadLine());
}


int LengthNum(int Number) // Получение количества цифр в числе
{
    int DigCount=0;
    while(Math.Abs(Number)>0)
    {
        Number=Number/10;
        DigCount++;
    }
    return DigCount;
}

int GetDigitFromNumber(int Number, int index) // Получение значение цифры в числе
{
    int num = Number/Convert.ToInt32(Math.Pow(10,LengthNum(Number)-index))%10;
    return num;
}
 
int GetSum(number)
{
  int num = GetNumber(number)
    
    for (int i = 1; i <= num; i++)
      
      
Console.WriteLine("Вторая цифра: " + GetDigitFromNumber(num,2));
Console.WriteLine("Третья цифра: " + GetDigitFromNumber(num,3));
Console.WriteLine("Четвертая цифра: " + GetDigitFromNumber(num,4));
Console.WriteLine("Пятая цифра: " + GetDigitFromNumber(num,5));







//
int GetNumber()
{
            Console.WriteLine("Введите число: ");
      return Convert.ToInt32(Console.ReadLine());
}

int GetSum (int num)
{
    int i = 0;
    int sum = 0;
     
     while(num < 0 || num > 0)
    {
        num = Math.Abs(num / 10);  // модуль числа
        sum = 
       
       i++;
    }
      
      
      for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = GetNumber();
Console.WriteLine("Сумма цифр в веденном числе равна: " + GetSum(number));
