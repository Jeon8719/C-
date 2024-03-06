using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    int a = int.Parse(Console.ReadLine());
    if (a == -1) break;
    List<int> b = new List<int>();
    for (int i = 1; i < a; i++)
    {
        if (a% i == 0)
        {
            b.Add(i);
        }
    }
    int c = 0;
    for (int i = 0; i < b.Count; i++)
    {
        c += b[i];
    }
    if (c == a)
    {
        sb.Append(a);
        sb.Append(" = ");
        for (int i = 0; i < b.Count; i++)
        {
            sb.Append(b[i]);
            if (b.Last() != b[i]) sb.Append(" + ");
        }
        sb.AppendLine();
    }
    else sb.AppendLine($"{a} is NOT perfect.");
}
Console.WriteLine(sb.ToString());
