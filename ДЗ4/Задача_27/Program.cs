// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SummAllNumber( int number)
{
    int num = 0;
    while (number > 0)
    {
        num += number % 10;
        number = number / 10;
    }
    return num;
}

int number = Promt("Введите любое целое число: ");
Console.Write($"Сумма чисел в цифре {number} равна {SummAllNumber(number)}");
