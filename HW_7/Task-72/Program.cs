/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7 */
Console.WriteLine("Введите индекс строки:");
int indexRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца:");
int ndexColumn = Convert.ToInt32(Console.ReadLine());

int column=4;
int row = 3;
int[,] matrix= new int[row,column];

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

void PrintValue(int[,] matrix)
{
    if (indexRow>=0&&indexRow<row&&ndexColumn>=0&&ndexColumn<column)
    {
        Console.WriteLine(matrix[indexRow,ndexColumn]);
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
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

FillArray(matrix);
PrintArray(matrix);
PrintValue(matrix);