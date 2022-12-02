// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//Console.WriteLine("Введите число элементов массива: ");
//int array = new int[int.Parse(Console.ReadLine())];
int[] array = new int [8];
FillArray(array);
PrintArray(array);


