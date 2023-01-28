/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Random rnd = new Random();
double[] array = new double [4];
void FillArray (double[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=rnd.NextDouble()+rnd.Next(0,10);
    }
}

double MaxNumber(double[] array)
{   
    double max=array[0];
    for (int i=0; i<array.Length; i++)
    {
    if (array[i]>max)
    {
        max=max+array[i];
    }
    }
    return max;
}

double MinNumber(double[] array)
{   
    double min=array[0];
    for (int i=0; i<array.Length; i++)
    {
    if (array[i]<min)
    {
        min=min+array[i];
    }
    }
    return min;
}

FillArray(array);
double a = MaxNumber(array);
double b = MinNumber(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"максимум: {a:f2} ");
Console.WriteLine($"минимум: {b:f2} ");

//mas[i] =rnd.NextDouble()+rand.Next(0,10);
