int line = Convert.ToInt32(new Random().Next(3,6));
int column = Convert.ToInt32(new Random().Next(3,6));
double[,] matrix = new double[line, column];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Convert.ToInt32(new Random().Next(0,100));  
        Console.Write (matrix[i,j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < matrix.GetLength(1); j++) 
{
    double summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summa += matrix[i, j];
    }
    Console.WriteLine("Среднее арифметическое столбца "+(j+1)+" равно: "+ Math.Round(summa / matrix.GetLength(0), 2));
}