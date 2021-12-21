// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

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

void Replacement(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if(array.GetLength(0) != array.GetLength(1))
            {               
                break;
            }
            else
            {
                if (i == count) Console.Write(array[i, j]);
            } 
            count++;
        }
        if (count > 0) Console.WriteLine();
        if (count == 0)
        {
            Console.WriteLine("Это невозможно!");
            break;
        } 
        
    }
}

Console.Write("Введите количетство строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количетство столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Replacement(array);
