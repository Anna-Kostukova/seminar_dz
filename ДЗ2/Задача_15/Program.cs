// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void Week (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7)
   {
      Console.WriteLine("Этот день выходной");
   }
   else if (dayNumber < 1 || dayNumber > 7)
   {
      Console.WriteLine("Это вообще не день недели");
   }  
   else 
   { 
      Console.WriteLine("Этот день не выходной");
   }
}

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());
Week(dayNumber);
