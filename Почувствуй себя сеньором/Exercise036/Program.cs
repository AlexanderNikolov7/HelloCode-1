// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.
void PrintRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}


void AmountNumbers(int[] array)
{
    int amountEvenNumbers = 0;
    int amountOddNumbers = 0;
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amountEvenNumbers = amountEvenNumbers + count;
        if (array[i] % 2 != 0) amountOddNumbers = amountOddNumbers + count;
    }
    Console.WriteLine($"Количество четных чисел в данном массиве = {amountEvenNumbers}");
    Console.WriteLine($"Количество не четных чисел в данном массиве = {amountOddNumbers}");

}

int[] array = new int[30];
PrintRandomNumbers(array);
Console.WriteLine();
AmountNumbers(array);