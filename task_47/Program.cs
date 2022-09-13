Console.WriteLine("Задайте количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random random = new Random();

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", (matrix[i, j]));
    }
Console.WriteLine();
}
