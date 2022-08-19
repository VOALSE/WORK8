// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();

int[,] FillingMatrixSpirally(int index, int num, int[,] matrix) //Заполнение матрицы спирально
{
    for (int i = index; i < matrix.GetLength(0) - 1 - index; i++)
    {
        if (i == index)
        {
            for (int j = index; j < matrix.GetLength(1) - index; j++) matrix[i, j] = num++;
        }
        else matrix[i, matrix.GetLength(1) - 1 - index] = num++;
    }

    for (int i = matrix.GetLength(0) - 1 - index; i > index; i--)
    {
        if (i == matrix.GetLength(0) - 1 - index)
        {
            for (int j = matrix.GetLength(1) - 1 - index; j >= index; j--) matrix[i, j] = num++;
        }
        else matrix[i, index] = num++;
    }

    if (index == (matrix.GetLength(0) - 1) / 2)
    {
        if (matrix.GetLength(0) % 2 != 0) matrix[(matrix.GetLength(0) - 1) / 2, (matrix.GetLength(1) - 1) / 2] = num++;
        return matrix;
    }

    return FillingMatrixSpirally(index + 1, num, matrix);
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

int[,] matrix = new int[4, 4]; 
int num = 1;
int[,] matrixResult = FillingMatrixSpirally(0, num, matrix);
PrintMatrix(matrixResult);