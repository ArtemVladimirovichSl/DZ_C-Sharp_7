Console.WriteLine("Введите размеры массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i, j] = Convert.ToInt32(new Random().Next(0,100));  
    Console.Write (matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позиции элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > m || b > n) Console.WriteLine("Такой позиции в массиве нет");
else 
Console.WriteLine($"Значение элемента = {matrix.GetValue(a,b)}");