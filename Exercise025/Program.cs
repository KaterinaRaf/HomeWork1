// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵).   2, 4 -> 16

int GetNumber(string name) 
{
    Console.WriteLine("Введите число " + name);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetNumber("вводимое в степень");
int B = GetNumber("степень");

void GetProduct(int A, int B)
{
  Console.WriteLine("Число " + A + " в степени " + B + " равно " + Math.Pow(A,B));
}

GetProduct(A, B);
