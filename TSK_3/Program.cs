int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} ");
        if (!int.TryParse(Console.ReadLine()!, out int number) || number <= 0)
        {
            Console.WriteLine("Число введено неправильно.");
        }
        else return number;
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

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ArrayMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
            Console.Write($"{arrayC[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int rowsNumberOfAcolumnsNumberOfB = CheckNumbers("Введите число строк первой матрицы и столбцов второй матрицы:");
int rowsNumberOfBcolumnsNumberOfA = CheckNumbers("Введите число столбцов первой матрицы и строк второй матрицы:");
int[,] arrayA = CreateArrayWithRandomNumbers(rowsNumberOfAcolumnsNumberOfB, rowsNumberOfBcolumnsNumberOfA);
int[,] arrayB = CreateArrayWithRandomNumbers(rowsNumberOfBcolumnsNumberOfA, rowsNumberOfAcolumnsNumberOfB);
Console.WriteLine();
Console.WriteLine("Матрица А:");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица В:");
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine("Матрица C:");
Console.WriteLine();
ArrayMultiplication(arrayA, arrayB);