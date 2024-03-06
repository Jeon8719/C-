using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
LinkedList<int> Deque = new LinkedList<int>();

for (int i = 0; i < a; i++)
{
    string[] input = sr.ReadLine().Split();
    switch (input[0])
    {
        case "push_front":
            Deque.AddFirst(int.Parse(input[1]));
            break;
        case "push_back":
            Deque.AddLast(int.Parse(input[1]));
            break;
        case "pop_front":
            if (Deque.Count != 0)
            {
                sb.AppendLine(Deque.First().ToString());
                Deque.RemoveFirst();
            }
            else sb.AppendLine("-1"); ;
            break;
        case "pop_back":
            if (Deque.Count != 0)
            {
                sb.AppendLine(Deque.Last().ToString());
                Deque.RemoveLast();
            }
            else sb.AppendLine("-1"); ;
            break;
        case "size":
            sb.AppendLine(Deque.Count.ToString());
            break;
        case "empty":
            sb.AppendLine(Deque.Count == 0 ? "1" : "0");
            break;
        case "front":
            sb.AppendLine(Deque.Count != 0 ? Deque.First().ToString() : "-1");
            break;
        case "back":
            sb.AppendLine(Deque.Count != 0 ? Deque.Last().ToString() : "-1");
            break;
    }
}
sw.WriteLine(sb);
sw.Close();
sr.Close();
