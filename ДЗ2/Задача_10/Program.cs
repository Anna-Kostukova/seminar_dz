// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetRandomNumber()
{
int number = new Random().Next(100, 1000);
return number;
}

int GetLastDigit(int number1) 
{
    number1 = number1 / 10;
    return number1 % 10;
}

void PrintNumber(int num1) // невозвращаемый метод, выводим на печать
{
    Console.Write($"Вторая цифра числа: {num1}" + " ");
}

int num = GetRandomNumber();
PrintNumber(num);
int lastdigit = GetLastDigit(num);
PrintNumber(lastdigit);

