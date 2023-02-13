/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] matrix=new int[4,4];
int number=0;
for (int i = 0; i < length1; i++)//length1=4
{
    
for (int j = 0; j < length2; j++)//length2=4
{
    matrix[i,j]=number;
    number++;
}
for (int k = 0; k < length; k++)
{
    
}
for (int l = 0; l < length; l++)
{
    
}
for (int p = 0; p < length; p++)
{
    
}

}

void PrintMatrix (int [,] matrix)
{
    for (int  i= 0; i < 4; i++)
    {
        for (int j = 0; j< 4; j++)
        {
            Console.WriteLine(matrix[i,j]);
        }
    }
}

PrintMatrix(matrix);