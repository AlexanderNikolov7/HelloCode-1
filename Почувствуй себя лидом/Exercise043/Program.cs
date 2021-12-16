// Написать программу преобразования десятичного числа в двоичное.

Console.Write("Decimal: ");
int decimalNumber = int.Parse(Console.ReadLine());

int remainder;
string result = string.Empty;
while (decimalNumber > 0)
{
    remainder = decimalNumber % 2;
    decimalNumber /= 2;
    result = remainder.ToString() + result; // цифры сохраняются с права на лево: 1 01 101 1101 =  1101
}
Console.WriteLine("Binary:  {0}",result);
