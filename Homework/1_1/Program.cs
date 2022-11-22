// Напишите программу, которая на вход принимает три числа
// и выдаёт максимальное из этих чисел

Console.WriteLine("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число3: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num1 > max ) max = num1;
if (num2 > max ) max = num2;
if (num3 > max ) max = num3;

Console.Write ("Max = ");
Console.WriteLine (max);