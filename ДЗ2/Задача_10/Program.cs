// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetRandomNumber()
{
int number = new Random().Next(100, 1000); // метод выбора случайных чисел 0т 100 до 999
return number;
}

int GetLastDigit(int number1) // метод вычисления второй цифры
{
    number1 = number1 / 10;
    return number1 % 10;
}

void PrintNumber(int num1) // метод вывода текста на консоль
{
    Console.WriteLine($"Вторая цифра этого числа: {num1}" + " ");
}

int num = GetRandomNumber(); // выбрано число
Console.WriteLine("Число: " +  num); // выводим на консоль рандомное число
int lastdigit = GetLastDigit(num); // результат вычисления второго числа
PrintNumber(lastdigit); // выводим на консоль вторую цифру

