// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)  // метод печати
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int[] InputArray(int length) // метод заполнения массива
{
    int[] array = new int[length]; // массив с заданной длинной (стр.44)
    for (int i = 0; i < array.Length; i++) // идем по всей длинне массива
    {
        array[i] = Promt($"Введите {i + 1}-й элемент "); // вводим каждый элемент
    }
    return array;
} 
void PrintArray(int[] array) // метод печати элементов массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}"); // выводим на консоль каждый элемент
    }
}

int CountPositiveNumbers(int[] array) // метод подсчета положительных элементов массива
{
    int count = 0; // новый счетчик
    for (int i = 0; i < array.Length; i++)  // проходим по всей длинне массива
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Promt("Введите количество элементов > ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)} ");
