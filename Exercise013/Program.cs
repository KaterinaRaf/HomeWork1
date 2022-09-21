// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

int CreateNumber()  //генерация случайного числа
{
    return new Random().Next(0,1000);
}

int ShowThirdDigit(int Number) //описание метода
{
    if (Number < 100)
    {
        return -1;
    }
        return Number % 10;
}

int Number = CreateNumber();
int Third = ShowThirdDigit(Number);

Console.WriteLine(Number);

if (Third ==-1)
{
    Console.WriteLine("Третьей цифры в числе нет! Увы!");
}
else
{
    Console.WriteLine("Третья цифра в числе " +Third);
}
