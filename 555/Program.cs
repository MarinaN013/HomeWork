/*Задача. Создать игру тетрис.*/
Random rnd = new Random();

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
{  int numberFigure =rnd.Next(1,10);
    switch (numberFigure)
{
    case 1:
        matrix[0,2]=1;
        matrix[0,3]=1;
        matrix[0,4]=1;
        matrix[1,3]=1;
        break;
    case 2:
        matrix[0,2]=1;
        break;
    case 3:
        matrix[0,2]=1;
        matrix[0,3]=1;
        break;
    case 4:
        matrix[0,2]=1;
        matrix[0,3]=1;
        matrix[0,4]=1;
        break;
    case 5:
        matrix[0,2]=1;
        matrix[0,3]=1;
        matrix[0,4]=1;
        matrix[0,5]=1;
        break;
    case 6:
        matrix[0,2]=1;
        matrix[0,3]=1;
        matrix[0,4]=1;
        matrix[1,4]=1;
        break;
    case 7:
        matrix[0,2]=1;
        matrix[0,3]=1;
        matrix[0,4]=1;
        matrix[1,2]=1;
        break;
    case 8:
        matrix[0,2]=1;
        matrix[1,2]=1;
        matrix[1,3]=1;
        matrix[2,3]=1;
        break;
    case 9:
        matrix[0,3]=1;
        matrix[1,3]=1;
        matrix[1,2]=1;
        matrix[2,2]=1;
        break;
}
}

int EnterUser()
{
    int shift=0;
    Console.WriteLine(" <-- 1,  --> 2,   вниз 3");
    shift = Convert.ToInt32(Console.ReadLine());
    return shift;
}
//int valshift=EnterUser();
void ShiftFigure(int[,] matrix, int valshift)//провера на сдвиг, если ОК то сдвиг в лево
{
    if (valshift == 1)
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
                if (matrix[i,j]==3&&matrix[i,j+1]==1)
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
    else if (valshift == 2) //в право
    {
        int count1= 0;//проверка
        for (int i = 0; i <matrix.GetLength(0); i++)
        {
            for (int j =8; j>=0; j--)
            {
                if (matrix[i,j]==matrix[i,8]&&matrix[i,j]==1)//без повторения матрих
                {
                   count1++;
                }
                else if (matrix[i,j]==1&&matrix[i,j+1]==3)///выход из границ
                {
                    count1++;
                }
            }
        }
        if (count1==0)//сдвиг в право
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j= 8; j >=0; j--)
                {
                    if (matrix[i,j]==1)

                    {
                       matrix[i,j+1]=matrix[i,j];//
                        matrix[i,j]=0;
                    }

                }
            }
        }

    }
}
void ShiftDownFigure(int[,] matrix) // опускаем вниз
{
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
int check =0;
int CheckShiftDown(int[,]matrix)// проверка на опускание вниз
{
    //bool check=true;
    int count2=0;
    check=0;
    while(count2<=8)//matrix.GetLength(0)-1
    {
       
        for (int i = 0; i <8; i++)//matrix.GetLength(0)-1
        {
            for (int j = 0; j <8; j++)//matrix.GetLength(1)
            {
                /* if (matrix[i,j]==1&&matrix[i+1,j]==0)
                {
                    check=0;
                }
                if (matrix[i,j]==1&&matrix[i+1,j]==1)
                {
                    check=0;
                } */
                if (matrix[8,j]==1)  
                {
                    check++;
                }  
                if (matrix[i,j]==1&&matrix[i+1,j]==3) 
                {
                    check++;
                }  
                //else  check ++;
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
    for (int i = 1; i <=8; i++)//=
    {   sum=0;
            for (int j = 0; j <=8; j++)//=
            {
                sum=sum +matrix[i,j];
                if (sum==27)
                {
                    for (int k=i; k > 0; k--)//7 6 5 4 3 2 1 0
                    {
                        for (int l = 0; l <=8; l++)
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
    for (int i = 0; i <=8; i++)
        {
            for (int j = 0; j <=8; j++)
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

    /* TimerCallback timeCB = new TimerCallback(TimerShiftDown);
    Timer t = new Timer(  timeCB,  null,   0,   1000);  */
    
    while (s)// пока нет соприкосновений с низом либо с 3
    {
        //EnterUser();
        int valshift=EnterUser();
        if (valshift==1||valshift==2)
        {
            ShiftFigure(matrix, valshift);//провекра на сдвиг в лево /право если ОК то сдвиг
        }
        //TimerShiftDown(object );

        //bool TimerShiftDown(object state)
        
        int p=CheckShiftDown(matrix);
        //Console.WriteLine(p);
       
         if (p==0)//проверка на сдвиг вниз
         {
            ShiftDownFigure(matrix);//сдвигаем вниз
            PrintMatrix(matrix);
            Console.WriteLine();
            int p1=CheckShiftDown(matrix);

            if (p1>0)//проверка на соприкосновение
            {
            MergeAll(matrix);//есть соприкосновение с низом или с 3, то все 1 меняем на 3
            CheckFullString(matrix);//проверка на полную строку
            s=false;
            } 

          } 
            

        
        
    }
   f++; 
}

