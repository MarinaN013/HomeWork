/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
int column=4;
int row = 3;

int[,] matrix= new int[row,column];
double [] avr = new double[column];
Random rnd=new Random();

void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= rnd.Next(0,10);
        }
    }
}

void Average(int[,] matrix, double[] avr)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum=sum+matrix[i,j];
        } 
        avr [j]=sum/row;
    }
}

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]);
        }
        Console.WriteLine();
    }
}

void PrintArrayAvr (double[] avr)
{
        for (int i = 0; i <avr.Length; i++)
        {
            Console.Write($"{avr[i]:f1}  ");
        }
}

FillArray(matrix);
Average(matrix, avr);
PrintArray(matrix);
PrintArrayAvr(avr);