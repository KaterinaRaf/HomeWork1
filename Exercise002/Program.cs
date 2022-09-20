// Программа по выявлению максимально числа из 3-х введенных

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число");
int c = Convert.ToInt32(Console.ReadLine());

int Max = a;

if (Max < b)
{
    Max = b;
}
else if (Max < c)
{
    Max = c;
}
else
{
    Max = a;
}

Console.WriteLine($"Наибольшее из введенных чисел {Max}");