int a = 1;
for(int i = 0; i < 3; i++)
{
    a *= int.Parse(Console.ReadLine());
}
char[] b = a.ToString().ToCharArray();
List<int> list = new List<int>(10);
for(int i = 0;i < 10;i++)
{
    char c = char.Parse(i.ToString());
   list.Add(b.Where(x=>x.Equals(c)).Count());
}
for(int i = 0; i<10;i++)
{
    Console.WriteLine(list[i]);
}