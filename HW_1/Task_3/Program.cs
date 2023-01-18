Console.WriteLine("Введите число");
string str1 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);


if (num1%2==0)
{
    Console.WriteLine($"Число {num1} четное");
}

else Console.WriteLine($"Число {num1} нечетное");

