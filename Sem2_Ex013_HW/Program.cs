/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numAbs = Math.Abs(num);
string numAbsTxt = Convert.ToString(numAbs);

if (numAbsTxt.Length > 2) {
    Console.WriteLine($"Третья цифра этого числа - {numAbsTxt[2]}");
} else {
    Console.WriteLine("Третьей цифры нет");
}