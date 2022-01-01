// Найти сумму цифр числа.

int SumRec(int num)
{
    if (num == 0) return num;
    else return SumRec(num / 10) + num % 10;
}
Console.WriteLine(SumRec(1234));
