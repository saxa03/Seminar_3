//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.Clear();
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
int k = 1;

while (k<=N)
{
    Console.Write($"{Math.Pow(k,2)},");
    k++;
}
