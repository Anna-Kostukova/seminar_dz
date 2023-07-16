// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] Fill(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next();
    }
    return a;
}
void PrintMass(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
}

int N = Promt("Введите длину массива: ");
int[] array = new int[N];

// for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// Console.WriteLine();
PrintMass(Fill(array));