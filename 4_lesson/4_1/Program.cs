// Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.

int SumNums(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }

    return all_sum;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
