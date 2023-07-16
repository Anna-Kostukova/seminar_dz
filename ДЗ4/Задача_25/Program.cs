// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)  // метод печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Result(int number, int extent)  // метод вычисления , присваиваем число и степень
{
    int result = 1;  // переменная, накапливаем значения
    int i = 0;  // счетчик степени
    for (; i < extent; i++) // пока значение степени меньше назначенного пользователем, с шагом 1
    {
        result *= number; // число умножаем на себя
    }
    return result;
}

int number = Promt("Введите число: ");
int extent = Promt("Введите степень: ");
Console.Write($"Число {number} в степени {extent} равно {Result (number, extent)}");


