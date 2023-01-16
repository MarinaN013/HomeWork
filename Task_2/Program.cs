Console.WriteLine("Введите первое число");
string str1 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);

Console.WriteLine("Введите второе число");
string str2 = Console.ReadLine();
int num2 = Convert.ToInt32(str2);

Console.WriteLine("Введите третье число");
string str3 = Console.ReadLine();
int num3 = Convert.ToInt32(str3);
if (num1>num2&num1>num3)
{
    Console.WriteLine($"Первое число {num1} максимальное");
}
else if (num2>num1&num2>num3)
{
    Console.WriteLine($"Второе число {num2} максимальное");
}
else Console.WriteLine($"Третье число {num3} максимальное");
