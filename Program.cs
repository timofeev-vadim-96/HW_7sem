// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
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

void GetElement(int [,] array, int A, int B)
{
    if (A > array.GetLength(0) || B > array.GetLength(1)) System.Console.WriteLine("Такого элемента в массиве нет");
    else 
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i==A && j==B) System.Console.WriteLine($"Ваш элемент в массиве = {array [i,j]}");
            }
        }
    }
    
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

int [,] result = GetMatrix(rows, columns);
System.Console.WriteLine("Двумерный массив");
PrintMatrix(result);

System.Console.WriteLine("Введите номер строки элемента в массиве:");
int element0 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите номер столбца элемента в массиве:");
int element1 = Convert.ToInt32(Console.ReadLine());

GetElement(result, element0-1, element1-1);

