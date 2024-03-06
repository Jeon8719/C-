using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (N[0] == 0 && N[1] == 0 && N[2] == 0) break;
    else
    {
        Array.Sort(N);
        for (int i = 0; i < N.Length; i++)
        {
            N[i] = N[i] * N[i];
        }
        if (N[0] + N[1] == N[2])
        {
            sb.AppendLine("right");
        }
        else
        {
            sb.AppendLine("wrong");
        }
    }
}
Console.WriteLine(sb.ToString());