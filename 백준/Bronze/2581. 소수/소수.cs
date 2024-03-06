int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int d = 0;
List<int> list = new List<int>();
for (int i = a; i <= b; i++) 
{
    int c = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0) c++;
    }
    if (c == 2) list.Add(i);
}
for(int i = 0; i < list.Count ;i++)
{
    d+=list[i];
}
if (list.Count == 0)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(d);
    Console.WriteLine(list.First());
}
