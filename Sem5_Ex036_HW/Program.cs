/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
int[] array = new int[5];
int result = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++) {
    if (array[j] % 2 != 0) {
        result += array[j];
    }
}

Console.Write($"Сумма нечетных элементов массива -> {result}");