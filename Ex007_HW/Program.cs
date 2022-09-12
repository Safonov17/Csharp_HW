Console.Clear();
Console.WriteLine("Программа покажет, является ли введенное число четным или нет");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine($"Число {num} - чётное");
} else {
    Console.WriteLine($"Число {num} - нечётное");
}