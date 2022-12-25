// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int [,] GetMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int [,] InputMatrix)
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

int [,] GetColumnsSum(int [,] array)
{
    double columnSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            columnSum+=array[j,i];
        }
        System.Console.WriteLine($"Среднее арифметическое в {i+1} столбце = {columnSum/columns}");
        columnSum = 0;
    }
    return array;
}


int [,] result = GetMatrix(rows, columns);
System.Console.WriteLine("Двумерный массив");
PrintMatrix(result);
GetColumnsSum(result);

