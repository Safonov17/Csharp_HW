/*
Напишите программу, которая на вход принимает радиус круга и находит его 
площадь, округленную до целого числа.
Необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
10 -> 4
20 -> 7
30 -> 8
*/
Console.Clear();
Console.Write("Введите значение радиуса круга: ");
int rad = Convert.ToInt32(Console.ReadLine());
int max = 0;

// Находим значение площади круга по формуле
double result = Math.Round(Math.PI * Math.Pow(rad, 2));
Console.WriteLine($"Площадь круга равна -> {result}");

// Находим максимальную цифру в получившемся числе
int resultToInt = Convert.ToInt32(result);
while (resultToInt > 0) {
    if (max < resultToInt % 10) 
        max = resultToInt % 10;
        resultToInt /=10;
}
Console.WriteLine($"Максимальная цифра в этом числе -> {max}");