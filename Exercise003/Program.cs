Console.WriteLine("Даны два числа. Показать большее и меньшее число");
Console.WriteLine("Enter number1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number2:");
int num2 = int.Parse(Console.ReadLine());
    if(num1 > num2)
      {
             Console.Write(num1);
             Console.Write(" Больше чем ");
             Console.Write(num2);
      }
    else
     {
             Console.Write(num2);
             Console.Write(" Больше чем ");
             Console.Write(num1);
     }