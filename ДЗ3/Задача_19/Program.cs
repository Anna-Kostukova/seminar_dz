// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int number = int.Parse(value);
    return number;
}

int ReversNum(int a)
{
    int revNumber = 0;
    int temp = a;
    while (temp > 0)
    {
        revNumber = revNumber * 10 + temp % 10;
        temp /= 10;
    }
    return revNumber;
}

int a = Promt("Введите пятизначное число: ");
int reversed = ReversNum(a);

if (a >= 10000 && a <= 99999)
{
    if (reversed == a)
    {
        Console.WriteLine("Число является полиндромом.");
    }
    else
    {
        Console.WriteLine("Число НЕ является полиндромом.");
    }
}


