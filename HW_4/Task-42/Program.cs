/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11         82 -> 10         9012 -> 12 */

int GetNumber()
{
    Console.WriteLine("Введите число");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}

int num= GetNumber();
int a=0; 
int sum=0;

int GetLengthNumber(int num)
{
    while (num>=1)
    {
        a=num%10;
        sum=sum+a;
        num=num/10;

    }
    return sum;
}

int result = GetLengthNumber(num);
Console.WriteLine(result);

