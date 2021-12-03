// Программа проверяет пятизначное число на палиндромом.
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine("Это число является палиндромом!");
}
else
{
    Console.WriteLine("Это число не является палиндромом!");
}