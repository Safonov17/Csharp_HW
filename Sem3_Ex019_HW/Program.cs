﻿/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.WriteLine("Введите число: ");
    string num = Console.ReadLine();
    string rev = string.Concat(num.Reverse());
    Console.WriteLine(num == rev ? $"Число {num} - палиндром" : $"Число {num} - не палиндром");ЁЁ