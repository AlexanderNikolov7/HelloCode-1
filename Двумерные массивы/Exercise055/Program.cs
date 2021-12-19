// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
}

void Result(int[,] array, double columnSum)
{
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            columnSum = columnSum + array[rows, columns];
        }
        Console.WriteLine($"Среднее арифметическое столбца {columns + 1} = {columnSum / array.GetLength(0)}");
        columnSum = 0;
    }
}

int[,] array = new int[3, 4];
double columnSum = 0;
FillArray(array);
PrintArray(array);
Result(array, columnSum);