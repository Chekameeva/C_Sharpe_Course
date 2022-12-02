// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i]);
    }
}

Console.Write("Введите число элементов массива: ");
int[] array = new int[int.Parse(Console.ReadLine())];
FillArray(array);
PrintArray(array);


