string[] input = Console.ReadLine().Split();
string a = input[0];
int b = int.Parse(input[1]);
var dic = new Dictionary<string, int>();
for(int i = 0; i <=35; i++)
{
    if (i < 10)
    {
        dic.Add(i.ToString(), i);
    }
    else
    {
        dic.Add(((char)(i+55)).ToString(), i);
    }
}
int count = 0;
double total = 0;
for( int i = a.Length - 1; i >= 0; i--)
{
    total += ((double)Math.Pow(b, count) * dic[a[i].ToString()]);
    count++;
}
Console.WriteLine(total);
