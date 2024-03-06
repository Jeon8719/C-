StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
List<(int,int)>b = new List<(int,int)>();

for (int i = 0; i < a; i++)
{
    int[] c = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    b.Add((c[1], c[0]));
}
b.Sort();
for (int i = 0;i <a;i++)
{
    sw.WriteLine($"{b[i].Item2} {b[i].Item1}");
}
sr.Close();
sw.Close();
