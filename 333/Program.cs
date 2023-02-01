/*Задача. Создать игру тетрис.
Random rnd = new Random();
int nunberFigure =rnd.Next(1,11);  */

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

void PrintMatrix(int[,] matrix)
{ for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j= 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]);
    }
Console.WriteLine();
}    
}

void NewFigure(int[,] matrix)
{  //Random rnd= new Random();
    //if (rnd.Next(1,10)==2)
    //{
        matrix[0,2]=1;
        matrix[0,3]=1;
        matrix[0,4]=1;
        matrix[1,3]=1;
    //}
}

int EnterUser()
{
    int shift=0;
    Console.WriteLine("для сдвига в лево нажмите 1, для сдвига вправо нажмите 2");
    shift = Convert.ToInt32(Console.ReadLine());
    return shift;
}
//int valshift=EnterUser();
void ShiftFigure(int[,] matrix, int valshift)//провера на сдвиг, если ОК то сдвиг в лево
{
    if (valshift == 2)
    {
        int count= 0;// проверка
        for (int i = 0; i <matrix.GetLength(0); i++)
        {
            for (int j = 0; j <matrix.GetLength(1); j++)
            {
                if (matrix[i,j]==matrix[i,0]&&matrix[i,j]==1)//без повторения матрих
                {
                   count++;
                }
            }
        }
        if (count==0)//сдвиг в лево
        {
            for (int i = 0; i <matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==1)
                    {
                        matrix[i,j-1]=matrix[i,j];
                        matrix[i,j]=0;
                    }

                }
            }
        }
    }
    if (valshift == 1) //в право
    {
        int count1= 0;//проверка
        for (int i = 0; i <matrix.GetLength(0); i++)
        {
            for (int j = matrix.GetLength(1); j>=0; j--)//
            {
                if (matrix[i,j]==matrix[i,matrix.GetLength(1)]&&matrix[i,j]==1)//без повторения матрих
                {
                   count1++;
                }
            }
        }
        if (count1==0)//сдвиг в право
        {
            for (int i = 0; i <matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1); j >=0; j--)//?
                {
                    if (matrix[i,j]==1)

                    {
                       //matrix[i,j-1]=matrix[i,j];
                        matrix[i,j]=5;
                    }

                }
            }
        }

    }
}
void ShiftDownFigure(int[,]matrix) // опускаем вниз
{
    for (int i = matrix.GetLength(0); i <1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]==1)
            {
                matrix[i,j]=matrix[i+1,j];
                matrix[i,j]=0;


            }
        }
    }
}
int CheckShiftDown(int[,]matrix)// проверка на опускание вниз
{
    //bool check=true;
    int count2=0;
    int check=0;
    while(count2<=matrix.GetLength(0)-1)
    {
       
        for (int i = 0; i <matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j <matrix.GetLength(1); j++)
            {
                if ((matrix[i,j]==1&&matrix[i+1,j]==0)||matrix[i+1,j]==1)
                {
                    check=0;
                }
                else check ++;
            }
        }
        count2++;
    }
    return check;
}
//если false  то все 111 заменяем на 3
void CheckFullString(int[,]matrix) //проверка на строку и удаление ее со сдвигом вниз
{
    int sum=0;
    for (int i = 0; i <matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j <matrix.GetLength(1); j++)
            {
                sum=sum +matrix[i,j];
                if (sum==21)
                {
                    for (int k=i; k>=0; k--)
                    {
                        for (int l = 0; l < matrix.GetLength(1); l++)
                        {
                            matrix[k,l]=matrix[k-1,l]; 
                             matrix[k-1,l]=0;                       
                        }

                    }
                }

            }   
            
         }       


}
void MergeAll(int[,] matrix)//из 1 делаем 3
{
    for (int i = 0; i <matrix.GetLength(0); i++)
        {
            for (int j = 0; j <matrix.GetLength(1); j++)
            {
                if (matrix[i,j]==1)
                {
                    matrix[i,j]=3;
                }

            }
        }

}

int[,] matrix = new int [9,9];
LoadMatrix(matrix);
int f=0;
while (f<10)
{
    NewFigure(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    bool s =true;
    while (s)// пока нет соприкосновений с низом либо с 3
    {
        //EnterUser();
        int valshift=EnterUser();
        ShiftFigure(matrix,valshift);//провекра на сдвиг влево /право если ОК то сдвиг
        //если сдвинули то показать матрих
        PrintMatrix(matrix);
        Console.WriteLine();
         ShiftDownFigure(matrix);//сдвигаем вниз
        //boll d = CheckShiftDown(matrix);
        int p=CheckShiftDown(matrix);
       if (p==0)//проверка на сдвиг вниз
        {
            ShiftDownFigure(matrix);//сдвигаем вниз
             
            int p1=CheckShiftDown(matrix);
            if (p1>0)//проверка на соприкосновение
            {
            MergeAll(matrix);//есть соприкосновение с низом или с 3, то все 1 меняем на 3
            CheckFullString(matrix);//проверка на полную строку
            PrintMatrix(matrix);
            Console.WriteLine();
            s=false;
            }
        } 
        
    }
   f++; 
}




