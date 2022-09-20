// Программа по определению четности числа

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());

if ((x % 2) == 0)
{
    Console.WriteLine("Введенное число четное!");
}
else
{
    Console.WriteLine("Введенное число НЕ четное!");
}