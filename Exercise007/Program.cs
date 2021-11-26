Console.WriteLine("Показать числа от -N до N");
// числа от -N до N = {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4}
int[] array = {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4};

int n = array.Length;
int index = 0;
    while (index < n)
    {
        if (index < n)
            {
                Console.WriteLine(array[index]);
            }
            index++;
    }