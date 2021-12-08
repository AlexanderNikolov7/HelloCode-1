// Написать программу замену элементов массива на противоположные
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Replacement(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        number = array[i] * -1;
        Console.Write($"{number} ");
    }
}

int[] collection = new int[10];
FillArray(collection);
PrintArray(collection);
Console.WriteLine();
Replacement(collection);