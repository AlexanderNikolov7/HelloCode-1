//Console.WriteLine("Найти третью цифру числа или сообщить, что её нет");
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if (num.Length < 3)
{
    Console.WriteLine("Третьей цифры числа, нет!");
}
else
{
    Console.WriteLine($"{"Третья цифра числа равна: "}{num[2]}");
}
