// Выяснить являются ли три числа сторонами треугольника.
// Формула: (a<b+c) and (b<a+c) and (c<a+b) = числа a,b,c являются сторонами треугольника.
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
if (a < (b + c) && b < (a + c) && c < (a + b)) Console.Write("числа a,b,c являются сторонами треугольника.");
else
{
    Console.WriteLine("числа a,b,c не являются сторонами треугольника.");
}
