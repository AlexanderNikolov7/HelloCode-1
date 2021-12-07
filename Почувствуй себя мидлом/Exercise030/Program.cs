// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите количество случайных чисел: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 99);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();
// Получился массив с случайно сгкенерированными числами
// Осталось найти чётные числа и возвести их в кубы
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) Console.Write($"{array[i]}^3 = {Math.Pow(array[i], 3)}; ");
}

