// Задание 3. Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.

using System.ComponentModel;

int[] CreateArray(int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

Console.WriteLine("Введите число от 1 до 8");
int number = Int32.Parse(Console.ReadLine());
if (number > 8 || number < 1)
{
    Console.Write("Число не входит в заданный диапозон чисел");
}

else
{
    int[] arr = CreateArray(number);
    Console.WriteLine("Массив:");
    foreach (int e in arr)
    {
        Console.Write(e + " ");
    }

    int integerNumber = 0;
    for (int i = 0; i < number; i++)
    {
        integerNumber = integerNumber * 10 + arr[i];
    }
    Console.Write($"\nЧисло из массива чисел - {integerNumber}");
}