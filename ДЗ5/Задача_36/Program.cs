// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

int arrSize = GetNum("Задайте размер массива: ");
int arrMin = GetNum("Введите минимальное значение массива: ");
int arrMax = GetNum("Введите максимальное значение массива: ");

int[] arr = GetArray(arrSize, arrMin, arrMax);

PrintArray(arr);
// FindNumber(arr);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int sum = 0;
for (int z = 1; z < arr.Length; z+=2)
    sum = sum + arr[z];

    Console.WriteLine($"всего {arr.Length} чисел, сумма элементов на нечётных позициях = {sum}");
