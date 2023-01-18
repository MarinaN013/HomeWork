/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/


Console.WriteLine("Введите чило");
int num = Convert.ToInt32(Console.ReadLine());

if (num==6||num==7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}
