// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] GetSummElementLine(int[,] matrixResult) //Сумма элементов в каждой строке
{
    int[] sumElement = new int[matrixResult.GetLength(0)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            sumElement[i] += matrixResult[i, j];
        }
    }
    return sumElement;
}

void SearchMin(int[] array) //поиск строки с минимальной суммой элементов и печать
{
    int min = array[0];
    int index=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            index=i;
        }
    }
    Console.WriteLine($"{index + 1} строка");
}

int[,] matrixResult = GetMatrix(4, 4);
PrintMatrix(matrixResult);

Console.WriteLine();
int[] summElementLine=GetSummElementLine(matrixResult);
SearchMin(summElementLine);