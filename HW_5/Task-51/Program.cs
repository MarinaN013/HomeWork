/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  

Алгоритм решения
1.инициализировать и заполнить массив
2.проверка на четность чисел
3. посчитать количество четных чисел
 */


Random rnd = new Random();
int[] array = new int [4];
void FillArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=rnd.Next(100,1000);
    }
}

int count=0;

int CountChetNumber(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
    if (array[i]%2==0)
    {
        Console.WriteLine(array[i]);
        count++;
    }
    }
    return count;
}

FillArray(array);
int a = CountChetNumber(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество четных элементов в массиве: {a} ");
