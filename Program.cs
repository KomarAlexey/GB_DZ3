// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine());
// if (num > 99999 || num < 10000)
// {
//     Console.Write("Введено не правильное число");
//     return;
// }
// if (num / 10000 != num % 10)
// {
//     Console.Write("Введеное число не является полиндромом");
// }
// else if ((num / 1000) % 10 != (num % 100) / 10)
// {
//     Console.Write("Введеное число не является полиндромом");
// }
// else
// {
//     Console.Write($"Число {num} является полиндромом");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите по очередно кординаты 1 точки : ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите по очередно кординаты 2 точки : ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z1-z2, 2));
Console.Write($"d = {d:f2}");