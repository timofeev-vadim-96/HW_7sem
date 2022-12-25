// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
double [,] GetMatrix(int m, int n)
{
    double [,] matrix = new double[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double [,] InputMatrix)
{
    for (int i = 0; i < InputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < InputMatrix.GetLength(1); j++)
        {
            System.Console.Write(InputMatrix[i,j] + "\t");
        }    
        System.Console.WriteLine();    
    }
}
System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] result = GetMatrix(rows, columns);
System.Console.WriteLine("Двумерный массив");
PrintMatrix(result);


