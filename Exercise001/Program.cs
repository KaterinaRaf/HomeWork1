// Программа по выявлению максимально числа из 2-х введенных

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Наибольшее из введенных чисел {a}");
}
else
{
    Console.WriteLine($"Наибольшее из введенных чисел {b}");
}