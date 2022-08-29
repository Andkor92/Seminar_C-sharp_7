// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] NewMatrix(int rows, int columns, int min = 10, int max = 100)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintElementOfMatrix(int[,] matrix, int[] position)
{
    if (position[0] - 1 >= matrix.GetLength(0) || position[1] - 1 >= matrix.GetLength(1))
    {
        Console.WriteLine($"Элемента на позиции ({string.Join((", "), position)}) в массиве нет!");
        return;
    }
    Console.WriteLine($"На позиции ({string.Join((", "), position)}) находится элемент {matrix[position[0] - 1, position[1] - 1]}.");
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = NewMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Введите номер строки и столбца искомого элемента через пробел: ");
int[] xy = Console.ReadLine().Split(" ").Select(Int32.Parse).ToArray();
Console.WriteLine();
PrintElementOfMatrix(matrix, xy);
