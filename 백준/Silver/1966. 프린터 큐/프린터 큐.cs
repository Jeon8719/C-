using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int T = int.Parse(sr.ReadLine());
Queue<int> queue = new Queue<int>();
for (int i = 0; i < T; i++)
{
    int count = 1;
    int[] NM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int N = NM[0];
    int M = NM[1];
    int[] Priority = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 0; j < N; j++)
    {
        queue.Enqueue(Priority[j]);
    }
    int find = Priority[NM[1]];
    while (true)
    {        
        if (queue.Peek() == queue.Max())
        {
            if (queue.Peek() == find && M == 0)
            {
                sb.AppendLine(count.ToString());
                break;
            }
            else
            {
                queue.Dequeue();
                count++;
                M--;
            }
        }
        else
        {
            if (queue.Peek() == find && M == 0)
            {
                M = queue.Count()-1;
            }
            else
            {
                M--;
            }
            queue.Enqueue(queue.Peek());
            queue.Dequeue();
        }
    }
    queue.Clear();
}
sw.Write(sb.ToString());
sr.Close();
sw.Close();

