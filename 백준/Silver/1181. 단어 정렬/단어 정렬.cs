int a= int.Parse(Console.ReadLine());
List<string> b = new List<string>();
for (int i= 0; i < a; i++)
{
     b.Add(Console.ReadLine().ToLower());
}
b= b.Distinct().ToList();
b.Sort();
b = b.OrderBy(x => x.Length).ToList();
foreach (string i in b)
{
    Console.WriteLine(i);
}