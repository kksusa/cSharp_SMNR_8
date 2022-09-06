﻿﻿int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param}: ");
        if (int.TryParse(Console.ReadLine()!, out int number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

void LeastRowSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
            Console.Write($"{array[i, j]}  ");
        }
        Console.Write($"сумма = {sum[i]}");
        Console.WriteLine();
    }
    int final = sum[0];
    int index = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < final)
        {
            final = sum[i];
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой чисел {index + 1}.");
}

int[,] array = CreateArrayWithRandomNumbers(CheckNumbers("Введите число строк"), CheckNumbers("Введите число столбцов"));
Console.WriteLine();
LeastRowSum(array);