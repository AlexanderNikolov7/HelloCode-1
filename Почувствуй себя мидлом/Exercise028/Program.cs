// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int num1 = num;
while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.WriteLine($"Cумму цифр в числе {num1} = {sum}");