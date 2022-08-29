// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] NewMatrixDouble(int rowsCount, int columnsCount, int afterComma, int minimum = -10, int maximum = 10)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rand.NextDouble() * (maximum - minimum) + minimum), afterComma);
        }
    }
    return matrix;
}
void PrintMatrixDouble(double[,] matrix)
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

Console.WriteLine("Задайте размер M массива со случайными вещественными числами: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте размер N массива со случайными вещественными числами: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество знаков после запятой для случайных вещественных чисел: ");
int a = Convert.ToInt32(Console.ReadLine());

double[,] matrix = NewMatrixDouble(m, n, a);
PrintMatrixDouble(matrix);
