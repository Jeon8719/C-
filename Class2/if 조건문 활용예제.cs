using System;
class Program
{
    static void Main(string[] args)
    {

        //if 조건문
        Console.Write("비밀번호 4자리를 입력하세요 : ____\b\b\b\b");
        string? input = Console.ReadLine();
        //int number = Convert.ToInt32(input);

        var outcome = int.TryParse(input, out int result);
        Console.WriteLine($"{outcome}");
        if (outcome)
        {
            Console.WriteLine($"입력한 숫자는 {result}");
        }
        else
        {
            Console.WriteLine(@"잘못된 입력입니다. 숫자만 입력하세요.");
        }
        string password = "1234";
        if (input == password)
        {
            Console.WriteLine("로그인 성공");
        }
        else if (input != password)
        {
            Console.WriteLine("로그인 실패");
        }
        Console.WriteLine("=========================");
        //=====================================================================
        Console.WriteLine("숫자를 입력하세요.");
        int inputnum = Convert.ToInt32(Console.ReadLine());
        if (inputnum == 0)
        {
            Console.WriteLine("0입니다.");
        }
        else if (inputnum % 2 == 0)
        {
            Console.WriteLine("짝수입니다.");
        }
        else
        {
            Console.WriteLine("홀수입니다.");
        }
        Console.WriteLine("종료합니다.");
        //=====================================================================   
        Console.WriteLine("당신의 점수는?");
        int score = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"너의 점수는 {score}");
        if (score >= 60)
        {
            Console.WriteLine("잘했다.");
        }
        else
        {
            Console.WriteLine("못했다.");
        }
        //=====================================================================
        Console.WriteLine("a값 입력");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b값 입력");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a - b >= 0)
        {
            Console.WriteLine($"두 값의 차이는 {a - b}다.");
        }
        else
        {
            Console.WriteLine($"두 값의 차이는 {-(a - b)}다.");
        }
        //=====================================================================
        Console.WriteLine("점수 입력");
        int score2 = Convert.ToInt32(Console.ReadLine());
        if (score2 >= 90)
        {
            Console.WriteLine("수");
        }
        else if (score2 >= 80)
        {
            Console.WriteLine("우");
        }
        else if (score2 >= 70)
        {
            Console.WriteLine("미");
        }
        else if (score2 >= 60)
        {
            Console.WriteLine("양");
        }
        else
        {
            Console.WriteLine("가");
        }

    }
}

 