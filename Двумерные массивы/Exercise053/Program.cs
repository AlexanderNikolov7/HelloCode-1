// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.
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

int count = 0;   // доп переменная для выполнения условия: "или указать, что такого элемента нет"
void FindNumberPosition(int[,] array, int num)
{
    Console.Write($"Число: {num}, находится на позиции: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                Console.Write($"{i},{j}.  ");
                count++;  // доп переменная для выполнения условия: "или указать, что такого элемента нет"
            }
        }
    }
}

int[,] array = new int[3, 5];
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
FillArray(array);
PrintArray(array);
FindNumberPosition(array, num);
if (count == 0) Console.WriteLine("заданного числа в данном массиве нет.");

