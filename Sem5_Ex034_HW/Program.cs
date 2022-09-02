/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(100, 999 + 1);
    Console.Write($"{array[i]} ");
}
for (int j = 0; j < array.Length; j++) {
    if (array[j] % 2 == 0) {
        count += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве -> {count}");