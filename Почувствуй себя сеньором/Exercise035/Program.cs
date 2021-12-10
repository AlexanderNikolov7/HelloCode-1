// Определить, присутствует ли в заданном массиве, некоторое число.
void PrintRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
}

void FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            Console.Write($"Число {find} присутствует в данном массиве.");
            break;
        }
        if (i +1 == array.Length)
        {
            Console.Write($"Число {find} не присутствует в данном массиве.");
        }

    }
}

int[] numbers = new int[10];
PrintRandomNumbers(numbers);
Console.WriteLine();
Console.Write("Ввдите число от 1 до 9: ");
int num = int.Parse(Console.ReadLine());
FindNumber(numbers, num);

