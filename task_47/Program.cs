Console.WriteLine("Задайте количество строк двумерного массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[line, column];   //создание массива с присвоением ему в качестве аргументов размеров матрицы

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        //заполнение двумерного массива случайными вещественными числами (с плавающей запятой) от -100 до 100
        Console.Write(Math.Round(matrix[i, j], 2) + " "); 
        //вывод массива на консоль с ограничением знаков после запятой до 2 символов и с пробелом между значениями матрицы
    }
Console.WriteLine();
}
