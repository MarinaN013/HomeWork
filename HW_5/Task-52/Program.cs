/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array= new int [10];
Random rnd= new Random();

void FillArray (int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        array[i]=rnd.Next(-10,11);
    }
}

int sum =0;
int SumNechetIndex (int[] array)
{
    for (int i=1; i<array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

FillArray(array);
int a = SumNechetIndex(array);
Console.WriteLine(string.Join("," ,array));
Console.WriteLine($"Сумма элементов стоящих на нечетных индексах:{a} ");
