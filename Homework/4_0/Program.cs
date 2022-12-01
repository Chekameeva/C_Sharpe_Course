// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Stepen(int A, int B)
{
    int x = 1;
    
    for (int i = 1; i <= B; i++)
    {
        x = x * A;
    }
    return x;
}

Console.WriteLine("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Stepen(num1, num2));