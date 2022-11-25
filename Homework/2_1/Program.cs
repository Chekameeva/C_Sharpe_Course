// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int DelTwo(int num)
{
    Console.WriteLine(num);
    return (num / 100) * 10 + (num % 100) % 10;
}

Console.WriteLine(DelTwo(new Random().Next(100, 1000)));