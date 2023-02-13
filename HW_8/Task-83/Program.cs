/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20                                    ///ДОБАВИТЬ ПРОВЕРКУ 
15 18 */
Console.WriteLine("Введите количество строк в 1 матрице:");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в 1 матрице:");
int column1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк в 2 матрице:");
int row2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в 2 матрице:");
int column2 = Convert.ToInt32(Console.ReadLine());


Random rnd= new Random();
int [,] matrix1 = new int[row1,column1];
int [,] matrix2 = new int[row2,column2];
int [,] matrix3 = new int[row1,column2];

void FillArray1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j]=rnd.Next(0,10);
        }
    }
}
void FillArray2( int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            
            matrix2[i,j]=rnd.Next(0,10);
        }
    }
}
//void FillArray3( int[,] matrix3)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            
            matrix3[i,j]=0;
        }
    }
}

void FindMinSumRow(int[,]matrix1,int[,]matrix2,int[,]matrix3)
{ 
    for ( int i = 0; i < matrix3.GetLength(0); i++)//2
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)//1
        {
            matrix3[i,j]=0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
        }
    }
}

void PrintArray1(int [,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j= 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray2(int [,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j= 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray3(int [,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j= 0; j < matrix3.GetLength(1); j++)
        {
            Console.Write($"{matrix3[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray1(matrix1);
FillArray2( matrix2);
//FillArray3(matrix3);
PrintArray1(matrix1);
PrintArray2(matrix2);
FindMinSumRow(matrix1,matrix2,matrix3);
PrintArray3(matrix3);

//if (column1==row2);
//количество столбцов первой количеству строк второй
