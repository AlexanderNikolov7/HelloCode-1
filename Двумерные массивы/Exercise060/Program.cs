// Составить частотный словарь элементов двумерного массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
}

void Matrix(int[,] array)
{
    int num = 0;
    for (int k = 0; k < 10; k++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (num == array[i, j]) count++;
            }
        }
        Console.WriteLine($"{num} встречается {count} раза.    "
        + $"Частота {Math.Round(Convert.ToDouble(count) / Convert.ToDouble(array.GetLength(0) * array.GetLength(1)) * 100, 3)}%");
        num++;
    }
}

int[,] array = new int[5, 9];
FillArray(array);
PrintArray(array);
Matrix(array);
