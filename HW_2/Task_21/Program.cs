/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int GetNumber()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    return (number%100)/10;
}
int firstNumber = GetNumber();
Console.WriteLine(firstNumber);






