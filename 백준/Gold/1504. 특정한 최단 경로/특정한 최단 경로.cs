
class Program
{
    static int N, E, v1, v2;
    static List<(int Next, int Weight)>[] Graph = new List<(int Next, int Weight)>[801];
    static int[] Dist = new int[801];

    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        N = int.Parse(inputs[0]);
        E = int.Parse(inputs[1]);

        for (int v = 1; v <= N; ++v)
        {
            Graph[v] = new();
        }

        for (int counter = 1; counter <= E; ++counter)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Graph[abc[0]].Add((abc[1], abc[2]));
            Graph[abc[1]].Add((abc[0], abc[2]));
            //방향성 x = 양방향 그래프
        }
        inputs = Console.ReadLine().Split();
        v1 = int.Parse(inputs[0]);
        v2 = int.Parse(inputs[1]);

        int sol1 = Dijkstra(1, v1) + Dijkstra(v1, v2) + Dijkstra(v2, N);
        int sol2 = Dijkstra(1, v2) + Dijkstra(v2, v1) + Dijkstra(v1, N);    
        int answer = Math.Min(sol1, sol2);
        if (Dijkstra(1, v1) == INF || Dijkstra(v1, v2) == INF || Dijkstra(v2, N) == INF ||
           Dijkstra(1, v2) == INF || Dijkstra(v2, v1) == INF || Dijkstra(v1, N) == INF)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(answer);
        }
    }

    const int INF = 987654321;
    static int Dijkstra(int start, int end)
    {
        for (int v = 1; v <= N; ++v)
        {
            Dist[v] = INF;
        }
        Dist[start] = 0;

        PriorityQueue<int, int> pq = new();
        pq.Enqueue(start, 0);

        while (pq.Count > 0)
        {
            int next = pq.Dequeue();

            foreach ((int neighbor, int weight) in Graph[next])
            {
                int d = Dist[next] + weight;

                if (Dist[neighbor] > d)
                {
                    Dist[neighbor] = d;
                    pq.Enqueue(neighbor, d);
                }
            }

        }
        return Dist[end];
    }

}