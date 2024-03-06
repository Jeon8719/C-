int a = 0;
List<int> b = new List<int>();
for(int i = 0; i < 5; i++)
{
    int c = int.Parse(Console.ReadLine());
    a += c;
    b.Add(c);
}
b.Sort();
Console.WriteLine(a/5);
Console.WriteLine(b[2]);
