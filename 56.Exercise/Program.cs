/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = FillArray(6, 4, 1, 10);


PrintArray(array);
Console.WriteLine();
NumberRowMinSumElements(array);


int[,] FillArray(int arrayRows, int arrayColumns, int MinValue, int MaxValue)
{
    int[,] filledarray = new int[arrayColumns, arrayRows];
    Random random = new Random();
    for (int i = 0; i < filledarray.GetLength(0); i++)
    {
        for (int j = 0; j < filledarray.GetLength(1); j++)
        {
            filledarray[i, j] = random.Next(MinValue, MaxValue);
        }
    }
    return filledarray;
}

void PrintArray(int[,] inputarray)
{
    for (int i = 0; i < inputarray.GetLength(0); i++)
    {
        for (int j = 0; j < inputarray.GetLength(1); j++)
        {
            System.Console.Write(inputarray[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}





