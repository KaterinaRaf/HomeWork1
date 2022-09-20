// Программа по определению четных чисел внутри введенного числа

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)
{
if ((i % 2) == 0)
Console.WriteLine(i);
i++;
}