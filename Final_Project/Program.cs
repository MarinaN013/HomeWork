
string text = "ому,в,та, произошло";
string[] words = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

int count=0;
  foreach (string s in words)
  {
    if (s.Length<=3)
    {
        count++;
    }
  }

string[] newArr = new string[count];
int i=0;
foreach (string s in words)
  {
    if (s.Length<=3)
    {
        newArr[i] = s;
        i++;
    }
  }

for (int c = 0; c < newArr.Length; c++)
{
    Console.Write($"{newArr[c]} ");
}
Console.WriteLine(newArr.Length);

