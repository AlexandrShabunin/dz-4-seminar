// Задача 25: Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите любое целое число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите любую степень: ");
int B = int.Parse(Console.ReadLine());

int Pow(int num, int temp)
{
    if (temp == 0) return 1;
    else 
    if (temp == 1 || num == 0 || num == 1) return num;

    int result = num;
    for (int i =2; i <= temp; i++)
    {
        result *= num;
    }return result;
}

Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");