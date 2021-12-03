// Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введиту значение N: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i}^2 = {i*i}");
}