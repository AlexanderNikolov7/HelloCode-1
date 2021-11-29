Console.WriteLine("Дано число из отрезка [10, 99]. Показать наибольшую цифру числа");
Console.WriteLine("Введите двухзначное число: ");
string num = Console.ReadLine();
char num1 = num[0];
char num2 = num[1];
if (num1 > num2)
{
    Console.Write("Наибольшая цифра числа ");
    Console.Write(num );
    Console.Write(" это ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Наибольшая цифра числа ");
    Console.Write(num );
    Console.Write(" это ");
    Console.WriteLine(num2);
}
