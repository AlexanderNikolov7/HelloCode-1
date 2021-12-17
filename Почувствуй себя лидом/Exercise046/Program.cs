// Написать программу масштабирования фигуры.
Console.Write("Во сколько раз увеличить масштаб фигуры?: ");
int k = int.Parse(Console.ReadLine());
int[,] matrix = new int[2*k, 2*k];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // Console.Write(matrix[i, j]);
        if (i == 0 && j == 0) Console.Write("+");
        if (i == 0 && j == matrix.GetLength(1) - 1) Console.Write("+");
        if (i == matrix.GetLength(0) - 1 && j == 0) Console.Write("+");
        if (i == matrix.GetLength(0) - 1 && j == matrix.GetLength(1) - 1) Console.Write("+");
        else Console.Write(" ");
    }
    Console.WriteLine();
}

