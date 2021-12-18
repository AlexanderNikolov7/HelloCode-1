// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Replace(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j % 2 == 0 && i % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}
int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
Replace(array);
PrintArray(array);
