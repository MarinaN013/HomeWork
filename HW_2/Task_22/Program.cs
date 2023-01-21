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


/*Решение без перевода числа в строку

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (number>999||number <-999)
 {
    while (number>999||number <-999)
    {
        number = number/10;
    }
 }
if (number>100&number<1000)
{
    result = number%10;
    Console.WriteLine(result);
}
else if (number<-100&number>-1000)
{
    result = (number%10)*-1;
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Число не трехзначное");
}
*/