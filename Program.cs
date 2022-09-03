// Семинар 3

// Задача . Определить четверть по введенным значеним координат в 2D пространстве. Причем X и Y не могут равняться 0. 

// Console.WriteLine("Введите координату OX: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату OY: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("I четверть");
// else if (x < 0 && y > 0) Console.WriteLine("II четверть");
// else if (x < 0 && y < 0) Console.WriteLine("III четверть");
// else Console.WriteLine("IV четверть");


// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите координатную четверть: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n == 1) Console.WriteLine("Координаты x > 0, координаты y > 0");
// else if (n == 2) Console.WriteLine("Координаты x < 0, координаты y > 0");
// else if (n == 3) Console.WriteLine("Координаты x < 0, координаты y < 0");
// else Console.WriteLine("Координаты x > 0, координаты y > 0");

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine("расстояние между точками равно: " + Math.Round(AB, 3));


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите целое число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int index = 1;

// while (index <= N)
// {
//     Console.WriteLine(Math.Pow(index, 2));

//     index ++;
// }


// Домашнее задание

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Вариант решения через преобразование в строку

// Console.WriteLine("Введите пятизначное число:");
// string Num = Convert.ToString(Console.ReadLine());

// //int lenghtNum = Num.Length;

// if ((Num [0] == Num[4]) && (Num [1] == Num[3])) Console.WriteLine($"Число {Num} является полиндромом");
// else Console.WriteLine($"Число {Num} не является полиндромом");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine("расстояние между точками равно: " + Math.Round(D, 2));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите целое число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//      Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}");
//  }