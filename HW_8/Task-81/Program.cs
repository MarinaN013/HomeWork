/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */
Console.WriteLine("Введите количество строк в матрице:");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в матрице:");
int column = Convert.ToInt32(Console.ReadLine());
Random rnd= new Random();

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rnd.Next(-100,100);
        }
    }
}

    /* if (intArray[indx] == intArray[i]) //если минимальный элемент равен текущему значению - ничего не меняем
        continue; */

void SortArray(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int min =matrix[i,j];
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,k]<min)
                {
                    min=matrix[i,k];
                }
            }
            matrix[i,j]=min;
        }
    }
}

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j= 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


int [,] matrix = new int[row,column];
FillArray(matrix);
SortArray(matrix);
PrintArray(matrix);