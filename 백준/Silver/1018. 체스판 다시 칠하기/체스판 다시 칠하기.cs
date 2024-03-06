var input = Console.ReadLine()!.Split(' ');
var n = int.Parse(input[0]);
var m = int.Parse(input[1]);
//입력받기
var board = new string[n];
for (int i = 0; i < n; i++)
    board[i] = Console.ReadLine()!;
//예제의 보드판 생성
int res = 64;
for (int i = 0; i <= n - 8; i++)
{
    for (int j = 0; j <= m - 8; j++)
    {
        //8*8 보드판과 비교
        int case1 = 0, case2 = 0;
        //BW 보드 경우와 WB 보드 경우 비교
        for (int k = i; k < i + 8; k++)
        {
            for (int l = j; l < j + 8; l++)
            {
                if ((k + l) % 2 == 0)
                {
                    if (board[k][l] != 'W') case1++; //WB 보드 경우++ 
                    if (board[k][l] != 'B') case2++; //BW 보드 경우++
                }
                else
                {
                    if (board[k][l] != 'B') case1++; //WB 보드 경우 ++
                    if (board[k][l] != 'W') case2++;//BW 보드 경우 ++
                }
            }
        }
        res = Math.Min(res, Math.Min(case1, case2));  //WB보드와 BW 보드중 작은 값을
                                                                               //8*8보드를 전부 수정했을 경우와 비교해서 작은 값 도출
        
    }
}

Console.WriteLine(res);