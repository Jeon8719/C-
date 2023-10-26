using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("점수를 입력하세요.");
        int data = Convert.ToInt32(Console.ReadLine());// data 변수에 들어갈 정수 입력
        if (data >= 90)
        {
            Console.Write("수");ㅁ
        }
        else if (data >= 80)
        {
            Console.Write("우");
        }
        else if (data >= 70)
        {
            Console.Write("미");
        }
        else if (data >= 60)
        {
            Console.Write("양");
        }
        else
        {
            Console.Write("가");
        }
    }

}