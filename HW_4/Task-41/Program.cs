/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)    2, 4 -> 16
 */

/*  Console.WriteLine("Введите первое число А");
 int a =Convert.ToInt32( Console.ReadLine());
 int A=a;

 Console.WriteLine("Введите второе число B");
  int b =Convert.ToInt32( Console.ReadLine());

for(int i=1; i<b; i++)
{
    a=a*A;
}

   Console.WriteLine(a); */

   int GetNumber()
   {
    Console.WriteLine("Введите первое число А");
    int num =Convert.ToInt32(Console.ReadLine());
    return num;
   }

    int A = GetNumber();
    int a=A;
    int B = GetNumber();

   int Power()
   {
    for (int i=1; i<B; i++)
    {
        A=A*a;
    }
    return A;
   }
  
   int c= Power();
    Console.WriteLine(c);