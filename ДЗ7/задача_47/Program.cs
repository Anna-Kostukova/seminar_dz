// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов:  ");
double[,] array = new double[rows, columns];
FillArray(array);
PrintArray(array);


int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random rand = new Random();
            array[i, j] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) столбцы
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

