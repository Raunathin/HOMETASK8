/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();

Console.Clear();

System.Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] array = FillArray(m, n, 1, 10);

SortToLower(array);
// Console.WriteLine();
PrintArray(array);


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
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;

                }
            }
        }
    }
}













