// Определить количество цифр в числе
Console.Write("Ввудите любое число: ");
string num = Console.ReadLine();
int numbers = 0;
for (int i = 0; i < num.Length; i++)
{
    numbers++;
}
Console.WriteLine($"Количество цифр в числе {num} = {numbers}");
