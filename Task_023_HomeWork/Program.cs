// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите X1:");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1:");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1:");
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2:");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2:");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2:");
int Z2 = int.Parse(Console.ReadLine());

double x = Math.Pow((X2-X1),2);
double y = Math.Pow((Y2-Y1),2);
double z = Math.Pow((Z1-Z2),2);
double d = Math.Sqrt(x+y+z);

Console.WriteLine($"A ({X1},{Y1},{Z1}); B ({X2},{Y2},{Z2}), -> {d:f3}");