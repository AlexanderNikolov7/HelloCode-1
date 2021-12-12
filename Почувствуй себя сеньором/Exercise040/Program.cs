// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
void PrintNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}

void DifferenceMaxMin(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальный эдемент = {max}");
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine($"Минимальный элемент = {min}");
    double result = 0;
    result = max - min;
    Console.WriteLine($"Разницу между максимальным и минимальным элементом = {result}");
}

double[] array = new double[10];
PrintNewArray(array);
DifferenceMaxMin(array);
