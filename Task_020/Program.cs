//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите X1:");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1:");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2:");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2:");
int Y2 = int.Parse(Console.ReadLine());
double x = Math.Pow((X1-X2),2);
double y = Math.Pow((Y1-Y2),2);
double d = Math.Sqrt(x+y);
 Console.WriteLine($"d = {d:f3}");