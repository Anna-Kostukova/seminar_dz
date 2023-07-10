// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetRandomNumber() 
{
int number = new Random().Next(100, 1000); 
return number;
}

int GetFirstDigit(int number1) 
{
    return number1 % 10;
}

int num = GetRandomNumber();
Console.WriteLine(num);
int ferstdigit = GetFirstDigit(num);
Console.WriteLine(ferstdigit);

