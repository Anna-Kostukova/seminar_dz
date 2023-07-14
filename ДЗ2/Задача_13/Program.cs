﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string msg) // сохраняем сообщение пользователя
{

    Console.WriteLine($"{msg}"); // выводим на консоль сообщение, которое ввел пользователь
    return int.Parse(Console.ReadLine()!);
}
int number = Prompt("Введите число"); // сообщение для пользователя

int fnumber(int number) // метод для чисел больше трехзначного
{
    while (number > 999)
    {
        number /= 10; // пока число не станет трехзначным будем делить на 10
    }
    return number % 10;  // число трехзначное - берем остаток от деления на 10
}

bool check(int number) // метод для чисел меньше трехзначного
{
    if (number < 100) 
        return false; // возвращаем ложь
    else return true; // возвращаем истину
}

if (check(number) != true) // если истина (число правда меньше трехзначного)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}"); // иначе - выводим текст
