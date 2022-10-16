// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double SumFor(double lowNumber, double hightNumber)
{
    double result = 0;
    if (lowNumber < hightNumber)
    {
        result = lowNumber + SumFor(lowNumber + 1, hightNumber);
    }
    else if (lowNumber == hightNumber)
    {
         result = result + hightNumber;
    }
    return result;
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
double m = Math.Truncate(GetNumberFromConsole("Введите нижнюю границу промежутка")),
       n = Math.Truncate(GetNumberFromConsole("Введите верхнюю границу промежутка"));
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumFor(m, n)}");