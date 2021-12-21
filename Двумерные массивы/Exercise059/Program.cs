// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

void Result(int[,] array)
{
    int min = 100;
    int count = 0;
    int rowSum = 0;
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            rowSum = rowSum + array[rows, columns];
        }
        if (rowSum < min)
        {
            count = rows + 1;
            min = rowSum;

        }
        Console.WriteLine($"Сумма строки {rows + 1} = {rowSum}");
        rowSum = 0;

    }
    Console.WriteLine($"Наименьшая сумма элементов в {count} строке");
}

int[,] array = new int[5, 9];
FillArray(array);
PrintArray(array);
Result(array);
