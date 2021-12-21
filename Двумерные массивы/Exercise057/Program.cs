// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void ArraySort(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1) - 1; column++)
        {
            for (int i = column + 1; i < array.GetLength(1); i++)
            {
                if (array[row, column] < array[row, i])
                {
                    int temp = array[row, column];
                    array[row, column] = array[row, i];
                    array[row, i] = temp;
                }
            }
        }
    }
}

int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
ArraySort(array);
PrintArray(array);





