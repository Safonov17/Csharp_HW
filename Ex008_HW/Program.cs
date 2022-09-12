Console.Clear();
Console.WriteLine("Программа для нахождения всех четных чисел от 1 до num");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1) {
    Console.WriteLine("Ошибка. Введите целое положительное число, начиная с 1");
} else {
    for (int i = 2; i <= num; i +=2) {
        Console.Write($"{i} ");
    }
}