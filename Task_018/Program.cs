// напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X не=0, Y не=0 и выдает номер четверти плоскости, в которой находится эта точка

Console.Clear();
Console.WriteLine("Введите значение X:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть");
}
else
if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else
if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть");
}
else
if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}
// решение преподавателя: "else" в данном примере не обязательно
