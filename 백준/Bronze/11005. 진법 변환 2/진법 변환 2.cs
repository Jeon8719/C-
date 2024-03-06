using System.Text;

string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
var dic = new Dictionary<int, string>();
for(int i = 0; i <=35; i++)
{
    if (i < 10)
    {
        dic.Add(i, i.ToString());
    }
    else
    {
        dic.Add(i, ((char)(i+55)).ToString());
    }
}
StringBuilder sb = new StringBuilder();
int div = a;
while (div > 0)
{
    int remainder = div % b;
    sb.Append(dic[(int)remainder]);
    div /= b;
}
for(int i = sb.Length - 1; i >= 0; i--)
{
    Console.Write(sb[i]);
}