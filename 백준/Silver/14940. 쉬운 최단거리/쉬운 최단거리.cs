using System.Text;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StringBuilder sb = new StringBuilder();
string[] inputs = sr.ReadLine().Split();
int N = int.Parse(inputs[0]);
int M = int.Parse(inputs[1]);
int[,] Graph = new int[N, M];
int[,] Dist = new int[N, M];
int[] start = new int[2];
for (int i = 0; i < N; ++i)
{
    int[] inputs2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 0; j < M; ++j)
    {
        Graph[i, j] = inputs2[j];
        Dist[i, j] = -1;
    }
}
for (int i = 0; i < N; ++i)
{
    for (int j = 0; j < M; ++j)
    {
        if (Graph[i, j] == 2)
        {
            start[0] = i; start[1] = j;
            break;
        }
    }
}
BFS(start[0], start[1]);
for (int i = 0; i < N; ++i)
{
    for (int j = 0; j < M; ++j)
    {
        if (Graph[i, j] == 0) sb.Append(0 + " ");
        else sb.Append(Dist[i, j] + " ");
    }
    sb.AppendLine();
}
sw.WriteLine(sb.ToString());
sw.Close();
sr.Close();

void BFS(int x, int y)
{   
    Queue<int[]> queue = new Queue<int[]>();
    queue.Enqueue(new int[] { x, y });
    Dist[x, y] = 0;
    int[] dx = { -1, 1, 0, 0 };
    int[] dy = { 0, 0, -1, 1 };
    while (queue.Count > 0)
    {
        int[] cur = queue.Dequeue();
        int curX = cur[0];
        int curY = cur[1];
        for (int i = 0; i < 4; ++i)
        {
            int nx = curX + dx[i];
            int ny = curY + dy[i];

            if (nx >= 0 && nx < N && ny >= 0 && ny < M && Graph[nx, ny] == 1 && Dist[nx, ny] == -1)
            {
                Dist[nx, ny] = Dist[curX, curY] + 1;
                queue.Enqueue(new int[] { nx, ny });
            }

        }
    }
}
sr.Close();
sw.Close();
