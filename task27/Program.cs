// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());

int SumMetod(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number%10;
        number /=10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр = {SumMetod(num)} ");