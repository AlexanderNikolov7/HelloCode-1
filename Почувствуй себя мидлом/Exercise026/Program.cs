// Возведите число А в натуральную степень B используя цикл
Console.Write("Введиту значение числа A: ");
double A = int.Parse(Console.ReadLine());
Console.Write("Введиту значение степени B: ");
double B = int.Parse(Console.ReadLine());
double sum = 1;
for (int i = 0; i < B; i++)
{
    sum = sum * A;
}
Console.WriteLine($"{"A^B"} = {sum}");