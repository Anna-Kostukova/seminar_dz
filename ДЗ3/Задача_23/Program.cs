// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
Console.Write(message + " ");
int num = int.Parse(Console.ReadLine()!);
return num;
}

void Cube(int num) // Метод для вычисления куба от "count" до "num"
{
int count = 1;
while (count <= num)
{
if (count == num)
Console.Write(count * count * count);
else
Console.Write(count * count * count + " ");

count++;
}
}

int n = GetNumber("Введите число:"); //запрашиваем переменную n у пользователя через функцию GetNumber
Cube(n); //Запускам функцию печати кубов от 1 до N