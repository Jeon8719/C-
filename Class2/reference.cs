using System;
using System.Data;

class Program
{
    static void Do(ref int number)
    {
        number = 20;
        Console.WriteLine(number);
    }
       
    static void Main()
    {
        int number = 10;
        Console.WriteLine(number);
        Do(ref number);
        //ref : reference 참조 받은 값으로 변경된 것이 유지된다.
        Console.WriteLine(number);
        Console.WriteLine($"현재시간:{DateTime.Now}");
        DateTime dt;
        if (DataSetDateTime.TryParse("2023-10-26", out dt))
        {
            Console.WriteLine(dt);
        }
        else
        {
            Console.WriteLine("날짜 형식으로 반환불가");
        }
    }
}

 
    