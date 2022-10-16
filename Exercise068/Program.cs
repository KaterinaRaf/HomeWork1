// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, 
                                        AckermanFunction(numberM, numberN - 1));
    return AckermanFunction(numberM,numberN);
}


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите число M : "),
    n = GetNumberFromConsole("Введите число N : ");
Console.WriteLine($"Функция Аккермана для чисел А({m},{n})={AckermanFunction(m,n)}");
