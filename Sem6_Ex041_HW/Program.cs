/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
*/
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int count = 0;

for (int i = 0; i < array.Length; i++) {
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Clear();
Console.Write("Полученный массив: ");
for (int i = 0; i < array.Length; i++) {
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++) {
    if (array[i] > 0) {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0 -> {count}");