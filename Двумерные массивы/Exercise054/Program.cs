// В матрице чисел найти сумму элементов главной диагонали.
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

void FindSum(int[,] array, int sum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, 0];
    }
    Console.WriteLine($"Сумму элементов главной диагонали = {sum}");
}

int[,] array = new int[3, 5];
int sum = 0;
FillArray(array);
PrintArray(array);
FindSum(array, sum);
