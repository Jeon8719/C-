StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

int[,] array;
bool[,] visit;
int count =0;
int house =0;
List<int> houseNum = new List<int>();
int[] dx = { 0, 0, -1, 1 };//좌우
int[] dy = { 1, -1, 0, 0 };//상하
//---------------------------------------------------------
//i,j 크기의 행렬 지도 생성
//---------------------------------------------------------
int N = int.Parse(sr.ReadLine());
array = new int[N, N];
visit = new bool[N, N];

for (int i = 0; i < N; ++i)
{
    var lint = sr.ReadLine();
    for (int j = 0; j < lint.Length; ++j)
    {
        array[i, j] = int.Parse(lint[j].ToString());
    }
}
//---------------------------------------------------------
//지도 탐색
//---------------------------------------------------------
for (int i = 0; i < N; ++i)
{
    for (int j = 0; j < N; ++j)
    {
        if (array[i, j] == 1 && !visit[i, j])//좌표 값이 1이고 방문하지 않았을 경우
        {
            Dfs(i, j); //단지 탐색 시작
            houseNum.Add(house); //단지 ++
            count++;//총 단지수 ++
            house = 0;//다음 단지의 집의 수 카운트를 위해 초기화
        }
    }
}
houseNum.Sort();//단지 내 집의 수 오름차순 정렬 후 출력
sw.WriteLine(count);
foreach (var num in houseNum)
{
    sw.WriteLine(num.ToString());
}


void Dfs(int i, int j)
{
    visit[i, j] = true; //방문 확인
    house++;//단지내 집의 수 카운트

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

sw.Close();
sr.Close();