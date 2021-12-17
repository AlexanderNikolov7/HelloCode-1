// Написать программу копирования массива.
int[] array = new int[10];
int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    newArray[i] = array[i];
    Console.WriteLine($"{array[i]} - {newArray[i]}");
}
