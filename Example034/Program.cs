// Программа, которая задаёт массив, заполненный случайными положительными трёхзначными числами,
// и показывает количество чётных чисел в массиве

int[] array = new int[10];

void FillArray(int[] collection)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CheckEvenNumbers()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество чётных элементов массива: " + count);
    return count;
}

FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
CheckEvenNumbers();
