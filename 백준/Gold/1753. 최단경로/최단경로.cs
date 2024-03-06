
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
const int INF = int.MaxValue;
List<(int, int)>[] Graph = new List<(int, int)>[20001];
int[] Dist = new int[20001];
string[] inputs = sr.ReadLine().Split();
int V = int.Parse(inputs[0]);
int E = int.Parse(inputs[1]);
int K = int.Parse(sr.ReadLine());

for (int i = 1; i <= V; ++i)
{
    Graph[i] = new();
}

for (int i = 1; i <= E; ++i)
{
    int[] uvw = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

    Graph[uvw[0]].Add((uvw[1], uvw[2]));
}

Shotcut();

for (int i = 1; i <= V; ++i)
{
    if (Dist[i] == INF)
    {
        sw.WriteLine("INF");
    }
    else
    {
        sw.WriteLine(Dist[i]);
    }
}

void Shotcut()
{
    for (int i = 1; i <= V; ++i)
    {
        Dist[i] = INF;
    }
    Dist[K] = 0;

    PriorityQueue<int, int> pq = new();
    pq.Enqueue(K, 0);

    while (pq.Count > 0)
    {
        int next = pq.Dequeue();

        foreach ((int a, int b) in Graph[next])
        {
            int d = Dist[next] + b;

            if (Dist[a] > d)
            {
                Dist[a] = d;
                pq.Enqueue(a, d);
            }
        }
    }
}
sr.Close();
sw.Close();