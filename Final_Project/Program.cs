
Console.WriteLine("Введите строку символов, разделенных запятыми");
string text = Console.ReadLine();
string[] words = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

int FindSumString (string [] words) //Находим сумму элементов, кторые меньше или равны 3
{
int sum=0;
  foreach (string s in words)
  {
    if (s.Length<=3)
    {
        sum++;
    }
  }
  return sum;//
}

void CreateNewArr(string [] words, string [] newArr)//Записываем в новый массив, все строки которые меньше или равны 3
{
int i=0;
foreach (string s in words)
  {
    if (s.Length<=3)
    {
        newArr[i] = s;
        i++;
    }
  }
}

void PrintNewArr(string [] newArr )//Выводим на консоль все строки нового массива
{
for (int j = 0; j < newArr.Length; j++)
{
    Console.Write($"{newArr[j]} ");
}
}

int count=FindSumString(words);
string[] newArr = new string[count];
CreateNewArr(words,newArr);
PrintNewArr(newArr);