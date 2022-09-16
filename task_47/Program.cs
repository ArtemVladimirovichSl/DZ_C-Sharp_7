Console.WriteLine("Задайте количество строк двумерного массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[line, column];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        Console.Write(Math.Round(matrix[i, j], 2) + " ");
    }
Console.WriteLine();
}
