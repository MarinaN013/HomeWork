/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/* Random rnd = new Random();
int[,,] matrix = new int[5,5,5];

for (int i = 0; i < 5; i++)
   for (int j = 0; j < 5; j++)
      for (int k = 0; k < 5; k++)
         matrix[i, j, k] = rnd.Next(10,100);
         if () */


//bool ContainsValue(V value): проверяет наличие элемента с определенным значением и возвращает true при его наличии в словаре
Random rnd = new Random();

int rows =2;
int columns =2;
int rows1 =2;
int columns1 =2;
int x =2;
int [,] matrix = new int [rows, columns];
int [,,] newMatrix=new int[rows1, columns1,x];

void  InitNewMatrix(int [,,] newMatrix )
{
    
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix.GetLength(2); k++)///
                newMatrix[i, j,k] = matrix[i,j];
        }
    }
    
}

void InitMatrix(int [,] matrix )
{
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
                matrix[i, j] = rnd.Next(10, 100);
        }
    }
    
}

void PrintMatrix(int [,,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix.GetLength(2); k++)
            {
                Console.Write($"{newMatrix[i,j,k]} ");
            }
            
        }
        Console.WriteLine();
    }
}
void CreateUnickNumbers(int [,] matrix)
{
Dictionary<int, int> Slovar = new Dictionary<int, int >();
//int[,] matrix = InitMatrix(4, 4);
int count=0;
while (count==0)
{
    
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        //for (int k = 0; k < matrix.GetLength(2); k++)
        
            if(Slovar.ContainsKey(matrix[i,j]))
            {count++;
            matrix[i,j]=rnd.Next(10,100);
            }

            //Slovar[matrix[i,j]] = Slovar[matrix[i,j]] + 1;
        else
            Slovar.Add(matrix[i,j], 1);
    }
}
}
}



InitMatrix(matrix);
CreateUnickNumbers(matrix);
InitNewMatrix(newMatrix );
PrintMatrix(newMatrix);

