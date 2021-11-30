//Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток.");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1} {"является кратным"} {num2}");
}    
else
{
    int res = num1 % num2;
    Console.WriteLine($"{"Остаток равен: "}{res}");
}
