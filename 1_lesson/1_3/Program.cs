// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа от -N до N

Console.WriteLine("Write number: ");

string num = Console.ReadLine();
int N = int.Parse(num);
int NegN = - N;

while(NegN <= N)
{
    Console.Write($"{NegN} ");
    NegN++;
}

