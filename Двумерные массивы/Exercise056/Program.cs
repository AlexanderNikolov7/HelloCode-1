// Написать программу, которая обменивает элементы первой строки и последней строки.
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
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RowsReplacement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) Console.Write(array[array.GetLength(0) - 1, j]);    // меняет первую строку на последнюю
            if (i == array.GetLength(0) - 1) Console.Write(array[0, j]);    // меняет последнюю строку на первую        
            if (i != array.GetLength(0) - 1 & i != 0) Console.Write(array[i, j]); // остальное оставляет без измененний        
        }
        Console.WriteLine();
    }
}

int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
RowsReplacement(array);