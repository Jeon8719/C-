StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine().Split();
int N = int.Parse(inputs[0]);
int M = int.Parse(inputs[1]);
int[] treeHeights = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
///입력 받고 찾기
int s = 0;
int e = 1000000000 + 1;
int answer = 0;
while (s < e)
{
    int m = (s + e + 1) / 2;
    long totalLength = 0;
    foreach(int treeHeight in treeHeights)
    {
        totalLength += Math.Max(0, treeHeight - m);
    }
    if(totalLength < M)
    {
        e = m - 1;
    }
    else
    {
        answer = Math.Max(answer, m);
        s = m;
    }
}
sw.WriteLine(answer);
sw.Close();
sr.Close();