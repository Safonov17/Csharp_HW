/*
Задайте значения M и N. 
Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии
M = 28; N = 7 -> 7
*/
Console.Clear();

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int GCD(int x, int y) {
   return y == 0 ? x : GCD(y, x % y);
}

int funcGCD = GCD(m, n);
Console.WriteLine($"Наибольший общий делитель этих чисел => {funcGCD}");