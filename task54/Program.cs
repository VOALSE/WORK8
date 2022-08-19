// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 4 1 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();

int[,] GetMatrix(int m, int n) //Создание рандомного двумерного массива, заполенного случайными числами
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array) //Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int[,] SortingArray(int[,] matrixResult) //Сортировка по возрастанию элементов каждой строки двумерного массива
{
    int[,] matrix = new int[matrixResult.GetLength(0), matrixResult.GetLength(1)];
    int temp = matrixResult[0, 0];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int n = 1; n < matrixResult.GetLength(1); n++)
            {
                if (matrixResult[i, n] <= matrixResult[i, n-1])
                {
                    temp = matrixResult[i, n];
                    matrixResult[i, n]=matrixResult[i, n-1];
                    matrixResult[i, n-1]=temp;
                }
            }
        }
    }
    return matrixResult;
}

int[,] matrixResult = GetMatrix(5, 5);
PrintMatrix(matrixResult);

Console.WriteLine();
int[,] sortingArray = SortingArray(matrixResult);
PrintMatrix(sortingArray);