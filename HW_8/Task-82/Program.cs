/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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
            matrix[i,j]=rnd.Next(0,10);
        }
    }
}

int sum1=1000;//магическое число
int result =0;

int FindMinSumRow(int[,]matrix)
{ 
  
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum= sum + matrix[i,j];
        }
        if (sum<sum1)
        { 
            sum1=sum;
            result=i;
        }
    }
    return result;
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
int b =FindMinSumRow(matrix);
PrintArray(matrix);

Console.WriteLine($"номер строки с наименьшей суммой элементов: {b} строка");