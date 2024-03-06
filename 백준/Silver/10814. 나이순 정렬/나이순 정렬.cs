int a= int.Parse(Console.ReadLine());
List<(int,string)> b = new List<(int, string)>();
for (int i= 0; i < a; i++)
{
    string[] c = Console.ReadLine().Split();
    b.Add((int.Parse(c[0]),c[1]));
    
}
b = b.OrderBy(x => x.Item1).ToList();
for (int c = 0; c < b.Count; c++)
{
    Console.WriteLine($"{b[c].Item1} {b[c].Item2}");
}