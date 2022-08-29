// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] NewMatrix(int rows, int columns, int minimumValue = 0, int maximumValue = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minimumValue, maximumValue);
        }
    }
    return matrix;
}
void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double[] ArithmeticalMeanColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        array[i] = Math.Round((sum / matrix.GetLength(0)), 3);
    }
    return array;
}

Console.WriteLine("Задайте размер M массива со случайными вещественными числами: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте размер N массива со случайными вещественными числами: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = NewMatrix(m, n);
PrintMatrixInt(matrix);
double[] average = ArithmeticalMeanColumn(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(("; "), average)}");
