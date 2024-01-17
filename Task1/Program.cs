// Задание 1. Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

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

bool IsSimple(int n)
{
    if (n < 2)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

int GetPrimeQuantity(int[] array)
{
    int countPrimes = 0;
    foreach (int e in array)
    {
        bool result = IsSimple(e);
        if (result == true)
        {
            countPrimes++;
        }
    }
    return countPrimes;
}

Console.WriteLine("Введите число");
int number = Int32.Parse(Console.ReadLine());
int[] arr = CreateArray(number);

Console.WriteLine("Массив:");
foreach (int e in arr)
{
    Console.Write(e + " ");
}

int count = GetPrimeQuantity(arr);
Console.WriteLine($"\nКолличество простых чисел в массиве - {count}");