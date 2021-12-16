// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы/
int k1 = int.Parse(Console.ReadLine());
int K2 = int.Parse(Console.ReadLine());
int B1 = int.Parse(Console.ReadLine());
int B2 = int.Parse(Console.ReadLine());
int X0 = 0;

while ((k1 * X0 + B1) != (K2 * X0 + B2))
{
    if (X0 == 100)
    {
        break;
    }
    X0++;
}
while ((k1 * X0 + B1) != (K2 * X0 + B2))
{
    X0 = 0;
    if (X0 == -100)
    {
        break;
    }
    X0--;
}
int y0 = k1 * X0 + B1;
Console.WriteLine("точка пересечения равна ( "+X0+";"+y0+" )");