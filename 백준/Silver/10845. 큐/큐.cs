using System.Text;

Queue<int> q = new Queue<int>();
StringBuilder sb = new StringBuilder();
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    string[] order = Console.ReadLine().Split();
    switch (order[0])
    {
        case "push":
            q.Enqueue(int.Parse(order[1]));
            break;
        case "front":
            if (q.Count > 0) sb.AppendLine(q.First().ToString()); else sb.AppendLine("-1");
            break;
        case "back":
            if (q.Count > 0) sb.AppendLine(q.Last().ToString()); else sb.AppendLine("-1");
            break;
        case "pop":
            if (q.Count > 0)
            {
                sb.AppendLine(q.Peek().ToString());
                q.Dequeue();
            }
            else sb.AppendLine("-1");
            break;
        case "size":
            sb.AppendLine(q.Count().ToString());
            break;
        case "empty":
            if (q.Count > 0) sb.AppendLine("0"); else sb.AppendLine("1");
            break;
    }
}
Console.WriteLine(sb.ToString());