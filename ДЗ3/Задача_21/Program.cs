// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double Distance(int a, int b, int c, int d, int i, int f) // метод расчета расстояния
{

    // return Math.Sqrt(Math.Pow((a-d), 2) + 
    //                Math.Pow((b-i), 2) + 
    //                Math.Pow((c-f), 2));
    double dist = Math.Sqrt((a - d) * (a - d) + (b - i) * (b - i) + (c - f) * (c - f));
    return dist;
}


int x1 = Promt("ВВедите x координату точки А : ");
int y1 = Promt("ВВедите y координату точки А : ");
int z1 = Promt("ВВедите y координату точки А : ");
int x2 = Promt("ВВедите x координату точки B : ");
int y2 = Promt("ВВедите y координату точки B : ");
int z2 = Promt("ВВедите y координату точки B : ");

Console.WriteLine("Расстояние между точками А и В " + Distance(x1, y1, z1, x2, y2, z2));