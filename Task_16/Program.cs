﻿// Напишите программу, которая принимает на вход два числа и проверяет, являются ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}