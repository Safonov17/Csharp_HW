/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
int[] array = new int[5];
int max = 0;
int min = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++) {
    if (array[j] > 0) {
        max = array[j];
    } else {
        min = array[j];
    }
}
Console.WriteLine($"{max} - ({min}) = {max - min}");