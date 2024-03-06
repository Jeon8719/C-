int a = int.Parse(Console.ReadLine());
List<int> b = new List<int>();
for(int i = 0; i < a; i++)
{
    b.Add(int.Parse(Console.ReadLine()));
}
b.Sort();
for(int i = 0;i < b.Count;i++)
{
    Console.WriteLine(b[i]);
}
