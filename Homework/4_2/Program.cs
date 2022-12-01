// See https://aka.ms/new-console-template for more information

int SumNums(int num)
{    
        num = num % 10;
        return num;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(SumNums(n));
