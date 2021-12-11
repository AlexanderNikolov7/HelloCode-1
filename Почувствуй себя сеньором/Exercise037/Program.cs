// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].
void PrintNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
        Console.Write($"{array[i]} ");
    }
}

void SegmentSearch(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100) count = count + 1;
    }
    Console.WriteLine($"Количество элементов из отрезка [10,99] = {count}");
}

int[] array = new int[123];
PrintNewArray(array);
Console.WriteLine();
SegmentSearch(array);