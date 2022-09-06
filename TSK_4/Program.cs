int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} ");
        if (!int.TryParse(Console.ReadLine()!, out int number) || number <= 0 || number > 4)
        {
            Console.WriteLine("Число введено неправильно.");
        }
        else return number;
    }
}

int[,,] CreateArrayWithRandomNumbers(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                while (true)
                {
                    bool check = false;
                    int temp = random.Next(10, 100);
                    foreach (var item in result)
                    {
                        if (item == temp)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        result[i, j, k] = temp;
                        break;
                    }
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[j, k, i]} {(j, k, i)}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int x = CheckNumbers("Введите первую размерность массива:");
int y = CheckNumbers("Введите вторую размерность массива:");
int z = CheckNumbers("Введите третью размерность массива:");
int[,,] array = CreateArrayWithRandomNumbers(y, z, x);
PrintArray(array);