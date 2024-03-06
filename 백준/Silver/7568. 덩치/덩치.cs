using System.Text;

StringBuilder sb = new StringBuilder();
int N = int.Parse(Console.ReadLine());
List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < N; i++)
{
    int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add((xy[0], xy[1]));
}

for (int i = 0; i < list.Count; i++)
{
    int rank = 0;
    for (int j = 0; j < list.Count; j++)
    {
        if (list[i].Item1 < list[j].Item1 && list[i].Item2 < list[j].Item2)
        {
            rank++;
        }
    }
    sb.Append(rank+1);
    sb.Append(" ");
}
Console.WriteLine(sb.ToString());
