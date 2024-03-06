StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
List<int>[] graph = new List<int>[100001];
int a = int.Parse(sr.ReadLine());
int[] parent = new int[100001];
for (int i = 1; i <= a; i++)
{
    graph[i] = new List<int>();
}
for (int i = 1; i <= a - 1; i++)
{
    int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    graph[b[0]].Add(b[1]);
    graph[b[1]].Add(b[0]);
}
Dfs(1);
for (int i = 2; i <= a; i++)
{
    sw.WriteLine(parent[i]);
}
//  1
// 4  6
//2 7  3
//      5
//그래프 생성

sw.Close();
sr.Close();
void Dfs(int x)
{
    foreach (int child in graph[x])
    {
        if (child == parent[x])
        {
            continue;
        }
        parent[child] = x;
        Dfs(child);
    }

}