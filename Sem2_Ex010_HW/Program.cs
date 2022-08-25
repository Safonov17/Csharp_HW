/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int numAbs = Math.Abs(num);

if (numAbs < 100 || numAbs > 999) {
    Console.WriteLine("Введено неверное значение. Повторите попытку");
} else {
    string stringNum = Convert.ToString(numAbs);
    Console.WriteLine($"Вторая цифра этого числа - {stringNum[1]}");
}