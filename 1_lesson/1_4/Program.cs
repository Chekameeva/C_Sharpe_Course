// Напишите программу вычисления модуля числа

Console.WriteLine("Write number: ");
var s = Console.ReadLine();
int N = s == null ? 0 : int.Parse(s);
Console.WriteLine($"{Math.Abs(N)}");
