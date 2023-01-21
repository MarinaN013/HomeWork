/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет 12821 -> да 23432 -> да */

Console.WriteLine("Введите чиcло");
string str = Console.ReadLine();

int count = 0;
int b = (str.Length/2);
int i=0;

while (i<b)
{
    if (str[i]==str[str.Length-1-i])
    {
        count++;
        if (count==b)
        {
           Console.WriteLine("Число является полиндромом"); 
        }
    }
    else 
    {
      Console.WriteLine("Число не полиндромом");
      break;  
    }  
    i++;
} 







    
