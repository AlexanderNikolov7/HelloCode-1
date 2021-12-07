// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

int[] collection = new int[8];
FillArray(collection);
PrintArray(collection);
