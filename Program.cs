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

// Console.Clear();
// // Console.WriteLine("Введите по очередно кординаты 1 точки : ");
// // int x1 = int.Parse(Console.ReadLine());
// // int y1 = int.Parse(Console.ReadLine());
// // int z1 = int.Parse(Console.ReadLine());
// // Console.WriteLine("Введите по очередно кординаты 2 точки : ");
// // int x2 = int.Parse(Console.ReadLine());
// // int y2 = int.Parse(Console.ReadLine());
// // int z2 = int.Parse(Console.ReadLine());
// // double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z1-z2, 2));
// // Console.Write($"d = {d:f2}");


// // Задача 23

// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// // Console.Clear();
// // Console.WriteLine("Введите число : ");
// // int num = int.Parse(Console.ReadLine());
// // int count =1;
// // while (count <= Math.Abs(num))
// // {
// //     Console.Write($"|{Math.Pow(count++, 3)}| ");
// // }




// Console.WriteLine("Enter a number: ");
// int numA = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("And its power: ");
// int numB = int.Parse(Console.ReadLine() ?? "0");
// numB = Math.Abs(numB);
// int firstA = numA;
// int i = 0;

// //Console.WriteLine($"{numA} raised to a power {numB} = {Math.Pow(numA, numB)}");

// if (numA == 0)
// {
//     Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");    
// }

// else 
// {
//     while (i < numB) 
//     {
//         numA *= firstA;
//         i++;
//     }
//     numA /= firstA;
//     Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");
// }



// int result = 50;
// for (int i = 0; i < 5; i++)
// {
//     result += 2;
//     Console.WriteLine(result);
// }


// Console.WriteLine($"Итог - {result}");






// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// char[] array = Math.Abs(num).ToString().ToCharArray();
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     int convert = int.Parse(array[i].ToString());  // int convert = array[i] - '0'; - второй вариант  
//     sum = sum + convert;
// }
// Console.Write($"Сумма цифр в числе {num} = {sum}");

// функции

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}


int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}



void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");
int[] myArray = CreateArray();
ShowArray(myArray);
















