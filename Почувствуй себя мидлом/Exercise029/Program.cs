// Написать программу вычисления произведения чисел от 1 до N
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Факториал числа {n} = {Factorial(n)}");