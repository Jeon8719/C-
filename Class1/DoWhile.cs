using System;
class program
{
    static void Main(string[] args)
    {
        int a = 0;
        do
        {
            Console.Write("숫자 입력 0=종료");
            a = int.Parse(Console.ReadLine());
        } while (a != 0); 
        //입력 값이 0이 아니면 계속 반복함.
        //while 조건식에 따라 do명령문을 반복하거나 중단
        //=====================================================
        int count = 0;
        do//처음 한번은 조건 없이 실행 후 테스트
        {
            Console.WriteLine($"안녕하세요{count}");
            count++;
        } while (count < 3);
        //테스트 후 조건에 따라 실행
        while (count < 3)
        {
            Console.WriteLine($"안녕하세요{count}");
            count++;
        }
    }
}
