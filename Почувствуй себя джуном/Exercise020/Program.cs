﻿//Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти плоскости координат: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)Console.WriteLine("Диапазон возможноых координат в этой четверти по X = 0 - N; по Y = 0 - N");
if (num == 2)Console.WriteLine("Диапазон возможноых координат в этой четверти по X = 0 - -N; по Y = 0 - N");
if (num == 3)Console.WriteLine("Диапазон возможноых координат в этой четверти по X = 0 - -N; по Y = 0 - -N");
if (num == 4)Console.WriteLine("Диапазон возможноых координат в этой четверти по X = 0 - N; по Y = 0 - -N");