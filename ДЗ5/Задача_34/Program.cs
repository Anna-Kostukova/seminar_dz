// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
GetArray(array);
PrintArray(array);
Console.WriteLine();
int count = 0;

for (int a = 0; a < array.Length; a++)
{
    if (array[a] % 2 == 0)
    count++;
}
Console.WriteLine($"{count} чисел в массиве чётные");

void GetArray(int[] array )
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}



