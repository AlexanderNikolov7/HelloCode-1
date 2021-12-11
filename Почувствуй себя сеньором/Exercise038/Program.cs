// Найти сумму чисел одномерного массива стоящих на нечетной позиции.
void PrintNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
        Console.Write($"{array[i]} ");
    }
}

void FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i]; // i0=1, i1=2, i2=3....
    }
    Console.WriteLine($"Сумму чисел одномерного массива стоящих на нечетной позиции = {sum}");
}

int[] array = new int[20];
PrintNewArray(array);
Console.WriteLine();
FindSum(array);
