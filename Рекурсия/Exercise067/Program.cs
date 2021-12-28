// Показать натуральные числа от N до 1, N задано.

string NumbersRec(int N)
{
    if (N == 1) return String.Empty + N;
    else return $"{N} " + NumbersRec(N - 1);
}
int N = 10;
System.Console.WriteLine(NumbersRec(N));
