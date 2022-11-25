// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int CentrNumber (int num)
{
    return (num / 10) % 10;
}

Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(CentrNumber(n));
