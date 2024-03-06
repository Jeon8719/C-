
using System.Collections;
using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
int last = 0;
Queue queue = new Queue();

for (int i = 0; i < a; i++)
{
    string[] input = sr.ReadLine().Split();
    if(input.Length > 1)
    {
        last = int.Parse(input[1]);
    }
    switch (input[0])
    {
        case "push":
            queue.Enqueue(last);
            break;
        case "pop":
            sb.AppendLine(queue.Count != 0 ? queue.Dequeue().ToString() : "-1");
            break;
        case "size":
            sb.AppendLine(queue.Count.ToString());
            break;
        case "empty":
            sb.AppendLine(queue.Count == 0 ? "1" : "0");
            break;
        case "front":
            sb.AppendLine(queue.Count != 0 ? queue.Peek().ToString() : "-1");
            break;
        case "back":
            sb.AppendLine(queue.Count != 0 ? last.ToString() : "-1");
            break;
    }
}
sw.WriteLine(sb);
sw.Close();
sr.Close();