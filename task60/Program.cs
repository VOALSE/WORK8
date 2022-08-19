// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


Console.Clear();

int[,,] GetArray(int m, int n, int k) //Создание рандомного трехмерного массива, заполенного числами от 10 
{
    int[,,] array = new int[m, n, k];
    int num = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = num ++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array) //Печать трехмерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                if (l == 0) Console.Write("[");
                if (l < array.GetLength(2) - 1) Console.Write($"{array[i, j, l],3},");
                else Console.Write($"{array[i, j, l],3}]");
            }
        }
        Console.WriteLine();
    }
}


int[,,] arrayResult = GetArray(3, 3, 3);
PrintArray(arrayResult);
