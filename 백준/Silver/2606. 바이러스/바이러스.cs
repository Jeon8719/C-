StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int computer = int.Parse(sr.ReadLine());
int computers = int.Parse(sr.ReadLine());
bool[] isVisited = new bool[101];
List<int>[] graph = new List<int>[101];
for (int i = 1; i <= computer; i++)
{
    graph[i] = new List<int>();
}
for (int i = 1; i <= computers; i++)
{
    string[] inputs = sr.ReadLine().Split();
    int u = int.Parse(inputs[0]);
    int v = int.Parse(inputs[1]);
    graph[u].Add(v);
    graph[v].Add(u);
}
int Dfs(int node)
{
    isVisited[node] = true;
    int result = 1;
    foreach (int next in graph[node])
    {
        if (isVisited[next] == false)
        {
            result += Dfs(next);
        }
    }
    return result;
}


sw.WriteLine(Dfs(1)-1);

sw.Close();
sr.Close();