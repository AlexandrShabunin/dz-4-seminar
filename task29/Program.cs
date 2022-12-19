// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int [] array = RandomArray(8, 0, 10000);
// применим метод Join - отвечает за объединение списка
// с помощью определенного указателя. Нам он нужен здесь для конвертации
// списка в строку.
Console.WriteLine($"[{String.Join(",", array)}] ");


int[] RandomArray(int size, int mindigit, int maxdigit)
{
    size = 8; // это размер массива из условия задачи
    int[] result = new int[size];
    for (int i = 0; i < 8; i++)
    {
        result[i] = new Random().Next(mindigit, maxdigit);
    }

    return result;
}