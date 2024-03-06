using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();

int[,] array;
bool[,] visit;
int count = 0;
int cabbage = 0;
List<int> cabbageNum = new List<int>();
int[] dx = { 0, 0, -1, 1 };//좌우
int[] dy = { 1, -1, 0, 0 };//상하

//---------------------------------------------------------
//i,j 크기의 행렬 지도 생성
//---------------------------------------------------------

int T = int.Parse(sr.ReadLine());
for(int t = 0; t < T; t++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int M = input[0]; // 가로 길이
    int N = input[1]; // 세로 길이
    int K = input[2]; // 배추 개수

    array = new int[N, M];
    visit = new bool[N, M];

    for (int k = 0; k < K; k++)
    {
        int[] input2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        array[input2[1], input2[0]] = 1;
    }
    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            if (array[i, j] != 1) array[i, j] = 0;
        }
    }
    //---------------------------------------------------------
    //지도 탐색
    //---------------------------------------------------------
    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            if (array[i, j] == 1 && !visit[i, j])//좌표 값이 1이고 방문하지 않았을 경우
            {
                Dfs(i, j); //배추 탐색 시작
                cabbageNum.Add(cabbage); //배추 ++
                count++;//총 배추 ++
                cabbage = 0;//다음 배추 수 카운트를 위해 초기화
            }
        }
    }
    cabbageNum.Sort();//단지 내 집의 수 오름차순 정렬 후 출력
    sb.AppendLine(count.ToString());
    count = 0;
    cabbage = 0;
}
sw.WriteLine(sb.ToString());
sw.Close();
sr.Close();



void Dfs(int i, int j)
{
    visit[i, j] = true; //방문 확인
    cabbage++;//단지내 집의 수 카운트

    for (int k = 0; k < 4; ++k)
    {
        int nextX = i + dx[k];
        int nextY = j + dy[k];
        //4방향 탐색 
        if (IsCheck(nextX, nextY))//입력된 지도 밖은 제외
        {
            if (array[nextX, nextY] == 1 && !visit[nextX, nextY])
            {
                Dfs(nextX, nextY);//방문하지 않은 좌표 값 1인 위치에서 다시 탐색시작
            }
        }
    }
}
bool IsCheck(int x, int y)
{
    return (x >= 0 && x < array.GetLength(0) &&
            y >= 0 && y < array.GetLength(1));
    //2차원은 GetLength(0)은 행의 개수, Getlength(1)은 열의 개수
}
