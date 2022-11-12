// Программа, которая задаёт одномерный массив, заполненный случайными числами,
// и находит сумму элементов, стоящих на нечётных позициях

int[] array = new int[10];

void FillArray(int[] collection)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 200);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SumOfElementsInOddPositions()
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + result);
    return result;
}

FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
SumOfElementsInOddPositions();