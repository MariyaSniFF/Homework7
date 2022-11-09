//Задания к семинару 7. Двумерные массивы
Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("47) Задача 47. Задайте двумерный массив размером m на n, заполненный случайными вещественными числами.");
        System.Console.WriteLine("50) Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        System.Console.WriteLine("52) Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        System.Console.WriteLine("0 End");

        int numTask = SetNumber("task");

        int SetNumber(string numberName)
        {
            Console.Write($"Введите номер задачи {numberName}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        switch (numTask)
        {
            case 0: return; break;
            case 47: MatrixRealNumbers(); break;
            case 50: MatrixElementReturnValue(); break;
            case 52: GetAverageColumnValues(); break;
            default: System.Console.WriteLine("Error"); break;
        }

    }

}
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
void MatrixRealNumbers()
{
    int rows = SetNumber("m");
    int column = SetNumber("n");

    int SetNumber(string name)
    {
        string[] arr = name.Split(" ");
        System.Console.WriteLine($"Введите числа {name}");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    double[,] matrix = GetRandomMatrix(rows, column);
    PrintMatrix(matrix);

    double[,] GetRandomMatrix(int rows, int column, int maxValue = 100, int minValue = -100)
    {
        double[,] matrix = new double[rows, column];
        var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }

    void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет."
void MatrixElementReturnValue()
{
    System.Console.WriteLine("Введите количество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов:");
    int column = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите номер строки:");
    int indexR = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите номер столбца:");
    int indexC = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = GetRandomMatrix(rows, column);
    PrintMatrix(matrix);

    int[,] GetRandomMatrix(int rows, int column, int maxValue = 10, int minValue = 0)
    {
        int[,] matrix = new int[rows, column];
        var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }

    void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    if (indexR < 0 | indexR > matrix.GetLength(0) | indexC < 0 | indexC > matrix.GetLength(1)) Console.WriteLine("Значения с такой позицией нет");
    else
    {
        int element = matrix[indexR - 1, indexC - 1];
        Console.WriteLine($"Значение элемента массива = {element}");
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void GetAverageColumnValues()
{
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, column];
    matrix = GetRandomMatrix(rows, column);
    PrintMatrix(matrix);

    int[,] GetRandomMatrix(int rows, int column, int maxValue = 10, int minValue = 0)
    {
        int[,] matrix = new int[rows, column];
        var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }

    void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[j, i];
        }
        double average = summ / column;
        int n = i + 1;
        Console.WriteLine($"Среднее арифметическое {n} столбца {average}");
    }
}