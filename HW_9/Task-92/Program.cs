/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.WriteLine("Введите положительное, натуральное число");
int M= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите положительное, натуральное число");
int N= Convert.ToInt32(Console.ReadLine());
int sum=0;

int PrintNumber(int M, int N)
{
    if (M<=N)
    {
        sum=sum+M;               
        M=M+1;
        PrintNumber(M,N);
    }
    return sum;
}
int a =PrintNumber(M,N);
Console.WriteLine(a);