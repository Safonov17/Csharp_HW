/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int exp = Exp(num1, num2);
Console.WriteLine($"{num1} ^ {num2} = {exp}");

int Exp(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
        result = result * num1;
    return result;
}