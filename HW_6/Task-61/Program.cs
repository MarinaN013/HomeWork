/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
//вводим через один Enter (разбиваем через Split())

Console.WriteLine("Введите массив из 8 чисел, разделенных пробелами, запятыми или точками");
string text = Console.ReadLine()!;
string[] splitArray = text.Split(',', StringSplitOptions.RemoveEmptyEntries);

int n = splitArray.Length;
int[] arr = new int[n];
int count =0;

for (int i = 0; i < arr.Length; i++)
{
  {
    arr[i] = Convert.ToInt32(splitArray[i]);
    if (arr[i]>0)
    {
      count++;
    }
  }
}
Console.WriteLine( "[{0}]", string.Join(", ", arr));
Console.WriteLine($"Количество положительных чисел: {count}");
