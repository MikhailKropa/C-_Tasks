﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write ("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());
int s1 = num / 10;
int s2 = s1%10;
Console.WriteLine(s2);


