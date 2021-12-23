// Найти произведение двух матриц.
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

void MatrixProduct(int[,] array1, int[,] array2, int[,] product)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++) // Этот цикл позволяет нужное число вставить в нужную ячейку
            {                                                // C  =  A  *  B
                product[i, j] = array1[i, j] * array2[j, i]; //0,0 = 0,0 * 0,0
                                //0,1 = 0,1 * 1,0
                break;                                       //0,2 = 0,2 * 2,0
            }                                                //1,0 = 1,0 * 0,1
        }                                                    //1,1 = 1,1 * 1,1
    }                                                        //1,2 = 1,2 * 2,1
}                                                            // Заметил определённую закономерность, она позволяет написать код 
                                                             // вот так: product[i, j] = array1[i, j] * array2[j, i];



int[,] array1 = new int[4, 5];
FillArray(array1);
Console.WriteLine("Матрица A:");
PrintArray(array1);
Console.WriteLine("Матрица B:");
int[,] array2 = new int[5, 4];
FillArray(array2);
PrintArray(array2);
int[,] product = new int[array1.GetLength(0), array2.GetLength(1)];
MatrixProduct(array1, array2, product);
Console.WriteLine("Произведение двух матриц (C):");
PrintArray(product);