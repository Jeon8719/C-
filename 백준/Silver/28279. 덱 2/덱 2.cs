using System.Text;

StringBuilder sb = new StringBuilder();
int a = int.Parse(Console.ReadLine());
LinkedList<int> Deque = new LinkedList<int>();
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    switch (b[0])
    {
        case 1:
            Deque.AddFirst(b[1]);
            break;
        case 2:
            Deque.AddLast(b[1]);
            break;
        case 3:
            if (Deque.Count > 0)
            {
                sb.AppendLine(Deque.First.Value.ToString());
                Deque.RemoveFirst();
            }
            else sb.AppendLine("-1");
            break;
        case 4:
            if (Deque.Count > 0)
            {
                sb.AppendLine(Deque.Last.Value.ToString());
                Deque.RemoveLast();
            }
            else sb.AppendLine("-1");
            break;
        case 5:
            sb.AppendLine(Deque.Count.ToString());
            break;
        case 6:
            sb.AppendLine(Deque.Count > 0 ? "0" : "1");
            break;
        case 7:
            sb.AppendLine(Deque.Count > 0 ? Deque.First.Value.ToString() : "-1");
            break;
        case 8:
            sb.AppendLine(Deque.Count > 0 ? Deque.Last.Value.ToString() : "-1");
            break;
    }
}
Console.WriteLine(sb.ToString());