Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (number>999)
 {
    while (number>999)
    {
        number = number/10;
    }
 }
if (number>100&number<1000)
{
    result = number%10;
    Console.WriteLine(result);
}
else
{
   Console.WriteLine("Число не трехзначное"); 
}




