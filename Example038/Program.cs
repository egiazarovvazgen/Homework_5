// Программа, которая задаёт массив вещественных чисел 
// и находит разницу между максимальным и минимальным элементом массива

double[] array = new double[10];

void FillArray(double[] collection)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 200) + random.NextDouble();
    }
}

void PrintArray(double[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double DiffBetweenMaxAndMinElements()
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
    Console.WriteLine("Максимальный элемент массива: " + max);
    Console.WriteLine("Минимальный элемент массива: " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + diff);
    return diff;
}

FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
DiffBetweenMaxAndMinElements();