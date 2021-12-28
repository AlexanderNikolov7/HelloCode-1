// Показать натуральные числа от M до N, N и M заданы.

string NumbersRec(int M, int N)
{
    if (M == N) return $"{M}";
    else return $"{M} " + NumbersRec(M + 1, N);
}
int m = 1;
int n = 10;
Console.WriteLine(NumbersRec(m, n));
