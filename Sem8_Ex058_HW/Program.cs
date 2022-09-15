/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();

Console.Write("Введите количество строк первой матрицы: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine()); // m
Console.Write("Введите количество столбцов первой матрицы: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine()); // n
Console.Write("Введите количество столбцов второй матрицы: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine()); // p
int rowsSecondMatrix = columnsFirstMatrix;

int[,] firstMartrix = new int[rowsFirstMatrix, columnsFirstMatrix];
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица ->");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[columnsFirstMatrix, columnsSecondMatrix];
FillArray(secondMartrix);
Console.WriteLine($"Вторая матрица ->");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Результирующая матрица ->");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix) {
  for (int i = 0; i < resultMatrix.GetLength(0); i++) {
    for (int j = 0; j < resultMatrix.GetLength(1); j++) {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++) {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void FillArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      array[i, j] = new Random().Next(2, 4);
    }
  }
}

void PrintArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}