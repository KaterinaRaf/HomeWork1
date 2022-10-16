// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void NaturalToLow(double number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        NaturalToLow(number - 1);
    }
    else if (number == 1)
    {
        Console.Write(number);
        Console.WriteLine();
    }
    if (number <= 0)
    {
        Console.WriteLine($"Натуральных чисел от 1 до {number} НЕТ!!");
    }
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
double number = GetNumberFromConsole("Введите число");
NaturalToLow(Math.Truncate(number));   // Truncate(Decimal) 
                                       //Вычисляет целую часть заданного десятичного числа.
                                       //Число округляется до ближайшего целого числа в сторону нуля.
