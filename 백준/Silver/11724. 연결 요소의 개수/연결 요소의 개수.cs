
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = input[0]; // 정점의 개수 1 ≤ N ≤ 1,000
int M = input[1]; // 간선의 개수0 ≤ M ≤ N×(N-1)/2

List<int>[] graph = new List<int>[N + 1];
bool[] visited = new bool[N + 1];
int ConnectedComponent = 0;

for (int i = 1; i <= N; i++)
{
    graph[i] = new List<int>();
}

// 그래프 정보 입력
for (int i = 0; i < M; i++)
{
    int[] edge = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int u = edge[0];
    int v = edge[1];
    graph[u].Add(v);
    graph[v].Add(u);
}

// 각 정점의 인접 리스트를 오름차순으로 정렬
for (int i = 1; i <= N; i++)
{
    graph[i].Sort();
}

// BFS 수행
for (int i = 1; i <= N; i++)
{
    if (!visited[i])
    {
        BFS(graph, visited, i);
        ConnectedComponent++;
    }
}

sw.WriteLine(ConnectedComponent);
sw.Close();
sr.Close();

void BFS(List<int>[] graph, bool[] visited, int start)
{
    Queue<int> queue = new Queue<int>();
    queue.Enqueue(start);
    visited[start] = true;

    while (queue.Count > 0)
    {
        int v = queue.Dequeue();
        foreach (int next in graph[v])
        {
            if (!visited[next])
            {
                visited[next] = true;
                queue.Enqueue(next);
            }
        }
    }
}