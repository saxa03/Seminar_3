﻿// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти:");
int num = int.Parse(Console.ReadLine());
if (num ==1)
{
    Console.WriteLine("X>0, Y>0");
}
if (num ==2)
{
    Console.WriteLine("X<0, Y>0");
}
if (num ==3)
{
    Console.WriteLine("X<0, Y<0");
}
if (num ==4)
{
    Console.WriteLine("X>0, Y<0");
}
// решение преподавателя:
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
case 1:
{
Console.WriteLine("x>0 y>0");
break;
}
case 2:
{
Console.WriteLine("x<0 y>0");
break;
}
case 3:
{
Console.WriteLine("x<0 y<0");
break;
}
case 4:
{
Console.WriteLine("x>0 y<0");
break;
}

default:
{
Console.WriteLine("Введена неправильная четверть");
break;
}
}
