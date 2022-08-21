Console.Clear();
Console.WriteLine("Программа покажет, какое из двух целых чисел большее, а какое меньшее");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2) {
    Console.WriteLine($"Число ({num1}) - большее");
    Console.WriteLine($"Число ({num2}) - меньшее");
} else {
    Console.WriteLine($"Число ({num1}) - меньшее");
    Console.WriteLine($"Число ({num2}) - большее");
}