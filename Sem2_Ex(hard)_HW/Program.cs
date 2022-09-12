/*
Дополнительная задача (задача со звёздочкой): 
Напишите программу, которая на вход принмает 3 трехзначных числа и 
находит среднее арифметическое, далее проверяет больше ли последняя цифра среднего арифметического, 
чем первая цифра минимума вводимых чисел.

111, 222, 333 - да
532, 164, 114 - нет
551, 235, 631 - цифры равны
*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int divider = 3;
int min = num1;

// Находим первую цифру в минимальном числе из вводимых
if (num2 < num1) {
    min = num2;
} else if (num3 < min) {
    min = num3;
}
int firstDigit = min / 10 / 10;

// Находим последнюю цифру в среднем арифметическом
int average = (num1 + num2 + num3) / divider;
int lastDigit = average % 10;

// Сравниваем две полученных цифры
if (lastDigit > firstDigit) {
    Console.WriteLine("Да");
} else if (lastDigit == firstDigit) {
    Console.WriteLine("Цифры равны");
} else {
    Console.WriteLine("Нет");
}