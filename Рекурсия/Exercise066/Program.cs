// Показать натуральные числа от 1 до N, N задано.

// string NumbersRec(int num, int N)
// {
//     if (num <= N)
//     {
//         return $"{num} " + NumbersRec(num + 1, N);
//     } 
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10)); 


string NumbersRec(int N)
{
    if (N == 1) return String.Empty + N;
    else return NumbersRec(N - 1) + $" {N}";
}
int N = 10;
Console.WriteLine(NumbersRec(N));