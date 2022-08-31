// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()));
int sum = 0;
while (num > 0) {
    sum = sum + num % 10;
    num /= 10 ;
}
Console.WriteLine($"Сумма чисел -> {sum}");