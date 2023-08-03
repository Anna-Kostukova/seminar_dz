// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine();
Console.WriteLine("Введите размер массива m x n и диапазон случайных значений: ");
int m = GetNum("Введите m: ");
int n = GetNum("Введите n: ");
int range = GetNum("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
GetArray(array);
PrintArray(array);
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
PrintArray(array);

void OrderArrayLines(int[,] array)  // сортировка массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int GetNum(string message) // ввод значений
{
  Console.Write(message);
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

void GetArray(int[,] array) // задаем числа для массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray(int[,] array) // печать массива
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