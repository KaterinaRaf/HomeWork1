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

 int GetSum(int Number)   // получение суммы цифр в числе
{
  int sum = 0;
  int Len = LengthNum(Number);
  
     for (int i = 0; i <= Len; i++)
    {
        int Digit = GetDigitFromNumber(Number, i);
        sum += Digit;
    }
    return sum;
}      
      
int number = GetNumber();
Console.WriteLine("Длина введеного числа = " + LengthNum(number));
Console.WriteLine("Сумма цифр в веденном числе равна: " + GetSum(number));
