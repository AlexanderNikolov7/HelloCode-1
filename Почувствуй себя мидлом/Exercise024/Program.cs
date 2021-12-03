// Найти кубы чисел от 1 до N
Console.Write("Введиту значение N: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    double res = Math.Pow(i, 3);
    Console.WriteLine($"{i}^3 = {res}");
}

