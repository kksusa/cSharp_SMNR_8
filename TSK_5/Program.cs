int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} ");
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

int[,] CreateSnakeArray(int m, int n)
{
    int[,] array = new int[m, n];
    int count = 1;
    int fromLeft = 0;
    int fromRight = 0;
    int fromTop = 0;
    int fromDown = 0;
    int numbersCount = 0;
    while (numbersCount < m * n)
    {
        for (int i = 0 + fromTop, j = 0 + fromLeft; j < array.GetLength(1) - fromRight; j++) // 1-я группа
        {
            if (numbersCount >= m * n) break;
            else
            {
                array[i,j] = count;
                count++;
                numbersCount++;
            }    
        }
        for (int i = 1 + fromTop, j = array.GetLength(1) - 1 - fromRight; i < array.GetLength(0) - fromDown; i++) // 2-я группа
        {
            if (numbersCount >= m * n) break;
            else
            {
                array[i,j] = count;
                count++;
                numbersCount++;
            }
            
        }   
        for (int i = array.GetLength(0) - 1 - fromDown, j = array.GetLength(1) - 2 - fromRight; j >= 0 + fromLeft; j--) // 3-я группа
        {
            if (numbersCount >= m * n) break;
            else
            {
                array[i,j] = count;
                count++;
                numbersCount++;
            }
            
        }   
        for (int i = array.GetLength(0) - 2 - fromDown, j = 0 + fromLeft; i > 0 + fromTop; i--) // 4-я группа
        {
            if (numbersCount >= m * n) break;
            else
            {
                array[i,j] = count;
                count++;
                numbersCount++;
            }
        }
        fromLeft++;
        fromRight++;
        fromTop++;
        fromDown++;
    }   
    return array;
}    

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                Console.Write($"0{array[i,j]} ");
            }
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] array = CreateSnakeArray(CheckNumbers("Введите число строк в массиве:"), CheckNumbers("Введите число столбцов в массиве:"));
PrintArray(array);