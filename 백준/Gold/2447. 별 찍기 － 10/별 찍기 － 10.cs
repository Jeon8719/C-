using System;
using System.Text;

class MainClass
{

    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        int n = int.Parse(sr.ReadLine());

        char[,] stars = new char[n, n];

        // 별을 공백으로 초기화
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                stars[i, j] = ' ';
            }
        }

        DrawStars(stars, 0, 0, n);

        // 결과 출력
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sb.Append(stars[i, j]);
            }
            sb.AppendLine();
        }
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
    
    // 재귀 함수를 사용하여 별을 그리는 메서드
    static void DrawStars(char[,] stars, int x, int y, int size)
    {
        if (size == 1)
        {
            stars[x, y] = '*';
        }
        else
        {
            int newSize = size / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 1 || j != 1)
                    {
                        
                        DrawStars(stars, x + i * newSize, y + j * newSize, newSize);
                    }
                }
            }
        }
    }
}
