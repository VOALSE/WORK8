// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] GetMulti(int[,] matrixFirst, int[,] matrixSecond)//Произведение двух матриц
{
    int[,] newMatrixResult = new int[matrixFirst.GetLength(0),matrixFirst.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            newMatrixResult[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
        }
    }
    return newMatrixResult;
}

int[,] matrixResultFirst = GetMatrix(3, 3);
int[,] matrixResultSecond = GetMatrix(3, 3);

PrintMatrix(matrixResultFirst);
Console.WriteLine();
PrintMatrix(matrixResultSecond);

Console.WriteLine();
Console.WriteLine();

int[,] newMatrixResult = GetMulti(matrixResultFirst,matrixResultSecond);
PrintMatrix(newMatrixResult);