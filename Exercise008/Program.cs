Console.WriteLine("Показать четные числа от 1 до N");
// пусть числа от одношо до N = {1,2,3,4,5,6,7,8,9,10}
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int index = 0; index < array.Length; index++)
{
    if (array[index] % 2 == 0)
        Console.WriteLine(array[index]);
}
