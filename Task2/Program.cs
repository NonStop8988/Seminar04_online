// Задание 2.Задайте массив из N случайных целых чисел (N вводится с клавиатуры). Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

using System.ComponentModel;

int[] CreateArray(int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

Console.WriteLine("Введите число");
int number = Int32.Parse(Console.ReadLine());
int[] arr = CreateArray(number);

Console.WriteLine("Массив:");
foreach (int e in arr)
{
    Console.Write(e + " ");
}

int count = 0;
foreach (int e in arr)
{
    if (e > 9)
    {
        if (e % 10 == 1 && e % 7 == 0)
            {
                count++;
            }
    }
}
Console.Write($"\nКоличество чисел - {count}");