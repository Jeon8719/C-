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
    }
}