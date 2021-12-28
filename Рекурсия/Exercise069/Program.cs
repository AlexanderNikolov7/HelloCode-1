// Найти сумму элементов от M до N, N и M заданы.

int SumRec(int M, int N)
{
    if (M == N) return 0;
    else return N + SumRec(M, N - 1);
}
int m = 1;
int n = 10;
Console.WriteLine(SumRec(m, n));
