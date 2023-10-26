using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("화장실 안내 서비스입니다.");
        Console.Write("성별을 입력하세요:__\b\b");

        string? sex = Console.ReadLine();
        if (sex == "남자" || sex == "남")
        {
            Console.WriteLine("오른쪽 화장실입니다.");
        }
        else if (sex == "여자" || sex == "여")
        {
            Console.WriteLine("왼쪽 화장실입니다.");
        }
        else
        {
            Console.WriteLine("남자 혹은 여자로 입력하세요.");
        }
        //=====================================================================
        Console.Write("첫번째 숫자를 입력:__\b\b");
        string? a = Console.ReadLine();
        var out1 = int.TryParse(a, out var n1);
        // int a = int.Parse(Console.ReadLine());
        Console.Write("두번째 숫자를 입력:__\b\b");
        string? b = Console.ReadLine();
        var out2 = int.TryParse(b, out var n2);
        //int b = Convert.ToInt32(Console.ReadLine());
        if (out1 && out2)
        {
            if (n1 >= n2) Console.WriteLine($"큰 값: {a}");
            else if (n1 < n2) Console.WriteLine($"큰 값: {b}");
        }
        else
        {
            Console.WriteLine("잘못 입력");
        }
        //=====================================================================
        Console.WriteLine("과목을 입력하세요.");
        string? title = Console.ReadLine();
        Console.WriteLine("점수를 입력하세요.");
        int score = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"과목은 {title}, 점수는 {score}");
        if (title == "수학")
        {
            if (score >= 60) Console.WriteLine("참 잘했어요.");
            else Console.WriteLine("분발하세요.");
        }
        else
        {
            if (score >= 80) Console.WriteLine("참 잘했어요.");
            else Console.WriteLine("분발하세요.");

        }
        //=====================================================================
        Console.WriteLine("점수를 입력하세요.");
        int score2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"점수는 {score2}");
        if (score2 >= 90)
        {
            Console.WriteLine("금메달");
        }
        else
        {
            if (score2 >= 80) Console.WriteLine("은메달");
            else
            {
                if (score2 >= 70) Console.WriteLine("동메달");
                else
                    Console.WriteLine("메달 없음. 분발하세요.");
            }
        }

    }
}

 