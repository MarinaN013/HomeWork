TimerCallback timeCB = new TimerCallback(TimerShiftDown);
Timer t = new Timer(  ShiftDownFigure,  null,   500,   1000);  
Console.ReadLine();


void ShiftDownFigure(object? obj, int[,] matrix )
{
    Console.WriteLine("gjfj");
    for (int i = 7; i >=0; i--)//????? проверка на сдвиг вниз
    {
        for (int j = 0; j <= 8; j++)
        {
            if (matrix[i,j]==1)
            {
                matrix[i+1,j]=matrix[i,j];
                matrix[i,j]=0;


            }
        }
    }
}
int [,] matrix= new int[3,4];

void LoadMatrix(int[,] matrix)
{
for (int i = 0; i <matrix.GetLength(0); i++)
{
    for (int j= 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]=0;
    }
}    
}

ShiftDownFigure(obj, matrix );