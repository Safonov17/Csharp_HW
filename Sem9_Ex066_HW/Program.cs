/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии
*/
Console.Clear();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n) {
  m = n; 
  n = temp;
}

void SumNaturalNumbers(int m, int n, int summ) {
  summ = summ + n;
  if (n <= m) {
    Console.Write($"Сумма натуральных чисел => {summ}");
    return;
  }
  SumNaturalNumbers(m, n - 1, summ);
}

SumNaturalNumbers(m, n, temp = 0);