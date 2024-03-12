using System.Text;
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int[,] array;
bool[,] visit;
int Day = 0;
int tomato = 0;
int[] dx = { 0, 0, -1, 1 }; // 좌우
int[] dy = { 1, -1, 0, 0 }; // 상하

// 입력 받기
int[] MN = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int M = MN[0];
int N = MN[1];
array = new int[N, M];
visit = new bool[N, M];

Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

for (int i = 0; i < N; ++i)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 0; j < M; ++j)
    {
        if (input[j] == 0) tomato++;
        if (input[j] == 1)
        {
            queue.Enqueue(new Tuple<int, int>(i, j));
            visit[i, j] = true;
        }
        array[i, j] = input[j]; // 1:토마토, 0:익지 않은 토마토, -1:토마토가 들어있지 않은 칸       
    }
}

// BFS 시작
while (queue.Count > 0)
{
    int size = queue.Count;
    for (int i = 0; i < size; i++)
    {
        var pos = queue.Dequeue();
        int x = pos.Item1;
        int y = pos.Item2;

        for (int k = 0; k < 4; k++)
        {
            int nextX = x + dx[k];
            int nextY = y + dy[k];
            if (IsCheck(nextX, nextY) && array[nextX, nextY] == 0 && !visit[nextX, nextY])
            {
                visit[nextX, nextY] = true;
                array[nextX, nextY] = 1;
                tomato--;
                queue.Enqueue(new Tuple<int, int>(nextX, nextY));
            }
        }
    }
    if (queue.Count > 0) Day++;
}

if (tomato == 0) // 모든 토마토가 익었을 때
    sb.AppendLine(Day.ToString());
else // 익지 않은 토마토가 남아있을 때
    sb.AppendLine("-1");

sw.Write(sb);
sw.Close();
sr.Close();


bool IsCheck(int x, int y)
{
    return (x >= 0 && x < array.GetLength(0) &&
            y >= 0 && y < array.GetLength(1));
}

