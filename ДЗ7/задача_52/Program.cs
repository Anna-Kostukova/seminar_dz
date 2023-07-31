// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
double[] avgNumbers = new double[array.GetLength(1)];
GetArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    avgNumbers[i] = result / array.GetLength(0);
}
PrintArr(avgNumbers);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
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
