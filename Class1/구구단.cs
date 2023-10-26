// ; (세미클론) : 작성 이후 명령 종료
// {} (블록) : 프로그램의 작성 범위
// 
using System;

class Program
{

    static void Main(string[] args)
    {
        //1.구구단 2~9까지 반복
        int i, j;

        for (i = 1; i <= 9; i++)
        {
            //구구단 계산식

            for (j = 2; j <= 9; j++)
            {
                Console.Write(j + "x" + i + "=" + j * i + "\t");
            }
            Console.WriteLine();

        }
        //i는 단, j는 곱해지는 값


        //i가 2단부터 9단까지 돌아가는 동안
        for (i = 2; i <= 9; i++)
        {
            Console.WriteLine("====" + i + "단" + "====");
            //j가 1부터 9까지 곱해짐
            for (j = 1; j <= 9; j++)
            {
                Console.WriteLine(i + " × " + j + " = " + (i * j));
            }
        }
    }
}