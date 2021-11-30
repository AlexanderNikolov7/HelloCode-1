//Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
Console.Write("Введите число дня недели: ");
int num = int.Parse(Console.ReadLine());
if(num == 6) Console.WriteLine($"{num}{" день недели - является выходным"}");
if(num == 7) Console.WriteLine($"{num}{" день недели - является выходным"}");
if(num > 7) Console.WriteLine($"{num}{" - это число не является днём недели"}");
else
{
    Console.WriteLine($"{num}{" день недели - не является выходным"}");
}