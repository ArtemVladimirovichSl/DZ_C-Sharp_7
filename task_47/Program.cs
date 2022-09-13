Console.WriteLine("Задайте количество строк двумерного массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[line, column];
Random random = new Random();

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.NextDouble() * 100;
        Console.Write(" " + "{0,6:F2}", (matrix[i, j]));
    }
Console.WriteLine();
}
