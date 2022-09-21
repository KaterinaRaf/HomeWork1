// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа

int CreateNumber()
{
    return new Random().Next(100,1000);
}
int ShowSecondDigit(int Number)
{
    int Hundred = Number / 100;
    int Ed = Number % 10;
    int Dec = (Number - Hundred*100 - Ed) / 10;
    return Dec;
}

int Number = CreateNumber();
Console.WriteLine(Number);
Console.WriteLine(ShowSecondDigit(Number));