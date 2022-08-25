/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.Write("Введите цифру: ");
int day = int.Parse(Console.ReadLine());


if (day > 0 && day < 8) {
    if (day > 5) {
        Console.WriteLine("Ура, выходной");
    } else {
        Console.WriteLine("Будний день");
    }
} else {
    Console.WriteLine("Ошибка введите число от 1 до 7");
}