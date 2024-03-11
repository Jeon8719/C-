using System.Text;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int N = int.Parse(sr.ReadLine());
int[,] graph = new int[N, N];
int white = 0;
int blue = 0;
for (int i = 0; i < N; i++)
{
    int[] squar = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 0; j < N; j++)
    {
        graph[i, j] = squar[j];
    }
}
cuting(0, 0, N);
sw.WriteLine(white);
sw.WriteLine(blue);
sw.Close();
sr.Close();

void cuting(int row, int col, int size)
{
    if (CheckColor(row, col, size))
    {
        if (graph[row, col] == 0)
            white++;
        else
            blue++;
        return;
    }

    int newSize = size / 2;
    cuting(row, col, newSize); // 왼쪽 위
    cuting(row, col + newSize, newSize); // 오른쪽 위
    cuting(row + newSize, col, newSize); // 왼쪽 아래
    cuting(row + newSize, col + newSize, newSize); // 오른쪽 아래
}

bool CheckColor(int row, int col, int size)
{
    int color = graph[row, col];
    for (int i = row; i < row + size; i++)
    {
        for (int j = col; j < col + size; j++)
        {
            if (graph[i, j] != color)
                return false;
        }
    }
    return true;
}



