// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным

int CreateNumber()  //генерация случайного числа, если надо автоматизировать проверку
{
    return new Random().Next(0,9);
}

int WeekDayStatus(int Number) // определяет границы вводимого числа
{
    if (Number >= 8)
    {
        return -1;
    }
    else if (Number <= 5) 
    {
        return 0;
    }
    return 1;
}

//Console.WriteLine("Введите число соответствующее дню недели!"); // для обратной связи с пользователем, вместо генерации
//int Number = Convert.ToInt32(Console.ReadLine());

int Number = CreateNumber(); // убрать, если есть обратная связь
Console.WriteLine(Number); // убрать, если обратная связь
int Day = WeekDayStatus(Number);

if (Day ==-1)
{
    Console.WriteLine("Такого дня недели не бывает!");
}
else if (Day ==0)
{
    Console.WriteLine($"{Number} - этот день недели будень");
}
else 
{
    Console.WriteLine($"{Number} - выходной!");
}