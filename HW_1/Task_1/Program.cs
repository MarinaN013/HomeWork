Console.WriteLine("Введите первое число");
string str1 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);

Console.WriteLine("Введите второе число");
string str2 = Console.ReadLine();
int num2 = Convert.ToInt32(str2);

if (num1>num2)
{
    Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
}
else if (num1==num2)
{
    Console.WriteLine("Числа равны");
}
else Console.WriteLine($"Второе число {num2} больше первого числа {num1}");