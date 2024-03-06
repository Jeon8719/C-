
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
string[] inputs = sr.ReadLine().Split();
int N = int.Parse(inputs[0]);
int M = int.Parse(inputs[1]);
int R = int.Parse(inputs[2]);
List<int>[] graph = new List<int>[ N + 1 ];
for (int i = 1; i <= N; i++)
{
    graph[i] = new List<int> ();
}
for (int i = 1;i <= M; i++)
{
    inputs = sr.ReadLine().Split();
    int u = int.Parse(inputs[0]);
    int v = int.Parse(inputs[1]);
    graph[u].Add(v);
    graph[v].Add(u);
}
for(int i = 1;i <= N;i++)
{
    graph[i].Sort();
    graph[i].Reverse();
}
int order = 1;
int[] isVisited = new int[N + 1];
Stack<int> st = new Stack<int>();
st.Push(R);

while(st.Count > 0)
{
    int nextNode = st.Pop();
    if (isVisited[nextNode]!=0)
    {
        continue;
    }
    isVisited[nextNode] = order++;
    foreach(int i in graph[nextNode])
    {
        if (isVisited[i] != 0)
        {
            continue;
        }
        st.Push(i);
    }
}
for (int i = 1; i <= N; i++)
{
    sw.WriteLine(isVisited[i]);
}

sw.Close();
sr.Close();