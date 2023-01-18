/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет*/

int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int firstNumber = GetNumber();

if (firstNumber>99)
{
    string str = Convert.ToString(firstNumber);
    Console.WriteLine(str[2]);
}
else if (firstNumber<-99)
{
    string str = Convert.ToString(firstNumber);
    Console.WriteLine(str[3]);
}
else
{
    Console.WriteLine("Число является не трехзначным");
}