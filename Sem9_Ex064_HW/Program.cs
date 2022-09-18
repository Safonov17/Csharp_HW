/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

void NaturalNumbers(int n, int count) {
  if (count > n) return;
  NaturalNumbers(n, count + 1);
  Console.Write($"{count} ");
}

NaturalNumbers(n, count);