﻿// Задача 43. Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double b1 = GetNum("Введите значение b1: ");
double k1 = GetNum("Введите значение k1: ");
double b2 = GetNum("Введите значение b2: ");
double k2 = GetNum("Введите значение k2: ");

double x = 0;
double y = 0;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Эти прямые имеют бесконечное количество точек пересечения, потому что они совпадают.");
}
else if (k1 == k2)
{
    Console.WriteLine("Эти прямые не имеют точек пересечения.");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;
    Console.Write($"Точка пересечения этих прямых ({x}; {y}).");
}





// Пример 1. Найти точку пересечения прямых y = 2x - 1 и y = -3x + 1.
// Решение: Для вычисления координат точки пересечения прямых, решим систему уравнений:

// y = 2x - 1
// y = -3x + 1
// Вычтем из первого уравнения второе
// y - y = 2x - 1 - (-3x + 1)
// y = -3x + 1
//       =>      
// 0 = 5x - 2
// y = -3x + 1
// Из первого уравнения найдем значение x
// 5x = 2
// y = -3x + 1
//       =>      
// x = 0.4
// y = -3x + 1
// Подставим значение x во второе уравнение и найдем значение y
// x = 0.4
// y = -3·(0.4) + 1 = -1.2 + 1 = -0.2
// Ответ. Точка пересечения двух прямых имеет координаты (0.4, -0.2)