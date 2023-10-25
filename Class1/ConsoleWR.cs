using System;

class Program
{

    static void Main(string[] args)
    {
        string? name;
        Console.Write("이름을 입력해주세요.");
        name = Console.ReadLine();
        //문장을 입력하는 기능
        //나이를 입력하는 코드 작성
        Console.Write("나이를 입력해주세요.");
        int age;
        age = Convert.ToInt32(Console.ReadLine());
        //Parse 데이터를 변환 ex) int.Parse( 데이터를 숫자로 변환 , string.Parse( 데이터를 문자로 변환
        Console.WriteLine($"이름 : {name}");
        Console.WriteLine("나이 : " + age);
    }

}
