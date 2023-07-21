// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

int sizeArray = GetNum("Введите длину массива: ");
int min = GetNum("Введите минимальное значение диапазона для элементов массива: ");
int max = GetNum("Введите максимальное значение диапазона для элементов массива: ");
int[] array = GetArray(sizeArray, min, max);
int count = 0;
for (int a = 0; a < sizeArray; a++)
{
    if (arr[a] % 2 == 0);
    count++;
}
Console.WriteLine($"{count} из них чётные");

PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

