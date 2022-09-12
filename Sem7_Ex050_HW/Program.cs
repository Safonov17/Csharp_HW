/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [3, 5];

FillArray(array);
PrintArray(array);

if (row > array.GetLength(0) || column > array.GetLength(1)) {
    Console.WriteLine("Такого элемента нет");
} else {
    Console.WriteLine($"Строка ({row}), столбец ({column}): {array[row-1, column-1]}");
}

void FillArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {        
            for (int j = 0; j < array.GetLength(1); j++) {
                array[i,j] = new Random().Next(100);
            }   
        }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) { 
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine(); 
    }
}