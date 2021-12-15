// Определить сколько чисел больше 0 введено с клавиатуры.
Console.WriteLine("Сколько чисел определить если они больше 0 ?");
int count = int.Parse(Console.ReadLine());
int numbers = 0;
for (int i = 1; i < count + 1; i++)   
{
    Console.WriteLine($"Введите число № {i}");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)numbers = numbers + 1;
}
Console.WriteLine($"{numbers} числа(ел) больше 0 введено с клавиатуры.");
