/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Random rnd = new Random();
Console.WriteLine("Введите высоту: ");
int rows1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину: ");
int columns1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите глубину: ");
int x =Convert.ToInt32(Console.ReadLine());
/* 
int rows1 =3;
int columns1 =6;
int x =2; */
int rows =(rows1*columns1*x);

int [] matrix = new int  [rows];
int [,,] newMatrix=new int[rows1, columns1,x];

void InitNewMatrix(int [,,] newMatrix )
{
    int rows=0;
    for ( int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for ( int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for ( int k = 0; k < newMatrix.GetLength(2); k++)///
            {
                newMatrix[i, j,k] = matrix[rows];
                rows++;
            }
        }
    }
}
void InitMatrix(int [] matrix )
{
    for (int i = 0; i < rows; i++)
    {
            matrix[i] = rnd.Next(10, 100);
    } 
} 
void PrintMatrix(int [,,] newMatrix)
{
    for (int k = 0; k < newMatrix.GetLength(2); k++)
    {
        for (int i = 0; i < newMatrix.GetLength(0); i++)//1
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)//1
            {
                Console.Write($"{newMatrix[i,j,k]} ({i},{j},{k}) ");
            }
           Console.WriteLine(); 
        }
    }
}
void CreateUnickNumbers(int [] matrix)
{
Dictionary<int, int> Slovar = new Dictionary<int, int >();

int i=0;
while (i<rows)//8
{ 
        if(!Slovar.ContainsKey(matrix[i]))
            {
               Slovar.Add(matrix[i], 1);
                i++;
            }
            else matrix[i]=rnd.Next(10,100);
}
}

InitMatrix(matrix);
CreateUnickNumbers(matrix);
InitNewMatrix(newMatrix );
PrintMatrix(newMatrix);




