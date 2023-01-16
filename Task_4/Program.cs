Console.WriteLine("Введите число");
string str1 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);

int count=0;

while(count<num1)
{
    count=count+1;
    if (count%2==0)
    {
       Console.WriteLine(count); 
    }
    
}

