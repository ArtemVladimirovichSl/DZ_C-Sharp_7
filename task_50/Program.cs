Console.Write("Введите количество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[line, column];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i,j] = new Random().Next(0,100);  
    Console.Write (matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите позицию элемента по горизонтали: ");
int numberLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по вертикали: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

if(numberColumn > column || numberLines > line) Console.WriteLine("Такого элемента в массиве нет");
else
Console.WriteLine($"Значение элемента = {matrix[numberColumn - 1, numberLines - 1]}");