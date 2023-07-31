// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = GetNum("Введите индекс строки: ");
int columns = GetNum("Введите индекс столбца: ");
int m = GetNum("Введите количество строк массива: ");
int n = GetNum("Введите количество столбцов массива: ");
int[,] array = new int[m, n];
GetArray(array);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

if (rows > array.GetLength(0) && columns > array.GetLength(1))
    Console.WriteLine("такого числа в массиве нет");
else
{
    object c = array[rows, columns];
    Console.WriteLine(c);
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
         Console.WriteLine();
    }
}

