// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void PrintNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
}


void Result(int[] array)
{
    int count = 1;
    int result = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array.Length / 2 == i) break;
        result = array[i] * array[array.Length - count];
        count++;
        Console.Write($"{result} ");
    }
}

int[] array = new int[10];
PrintNewArray(array);
Console.WriteLine();
Result(array);