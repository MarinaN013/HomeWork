/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index<length)
    {
        array[index] = new Random().Next(1,100);
        Console.Write($"{array[index]}, ");
        index++;
    }
    Console.WriteLine();
}
int[] array = new int[8];
FillArray(array);
int b=0;
void DivideArray(int[] array)
{
    int[] array1 = new int[5];
    int length2 = array.Length;
    
    for (int i=0; i<8; i++)
    {
        if (i<4)
        {
            array1[i]=array[i];
           Console.Write($"{array1[i]}, ");
        }
         if(i==5)
         {
            Console.WriteLine(); 
         }
         if (i>=4)
        {
            b=array[i];
            Console.Write($"{b}, ");
        }
    }
}
DivideArray(array);
