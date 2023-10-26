using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"안녕 {i}번째 반복");
        }
        int sum = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 != 0)
            { sum = sum + i; }
        }
        Console.WriteLine(sum);
        //=====================================================================
        Console.WriteLine("숫자를 입력해라.");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            for (int i2 = 0; i2 < i; i2++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
        //=====================================================================
        for (int i = 2; i <= 9; i++)
        {
            Console.WriteLine($"====={i}단=====");
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }
        }

        for (int k = 2; k < 10; k++)
        {

            Console.Write($"====={k}단=====\t");

        }
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 2; j < 10; j++)
            {
                Console.Write($"{j} X {i} = {i * j}\t");
            }
            Console.WriteLine();
        }
        //=====================================================================
        for (int i = 0; i < 10; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        //===================================================================== 
        Console.WriteLine("N의 값을 입력하세요.");
        int n = Convert.ToInt32(Console.ReadLine());
        long fact = 0;
        for (int i = 1; i <= n; i++)
        {
            fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact *= j;
            }
            Console.WriteLine($"{i}! -> {fact}");
        }
        //===================================================================== 
        string[] names = { "C#", "ASP.NET" };
        int[] ages = { 20, 30, 22 };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        //================================================================
        string[] p = { "사과", "배", "수박", "바나나" };
        for (int i = 0; i < p.Length; i++)
        {
            Console.WriteLine(p[i]);
        }
        foreach (string b in p)
        {
            Console.WriteLine(b);
        }
        //================================================================
        int t = 0;
        while (true)
        {
            Console.WriteLine(t);
            t++;
            if (t >= 5)
            {
                break;
            }

        }
        Console.WriteLine("While 정지");
        //================================================================
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i);

            if (i % 5 == 0)
            {
                break;
            }
        }
        Console.WriteLine("for loop 정지");
        //================================================================
        Console.WriteLine("목표치를 입력하세요.");
        int z = Convert.ToInt32(Console.ReadLine());
        int z1 = 0;
        int z2 = 0;
        while (true)
        {
            z1++;
            z2 += z1;
            if (z2 >= z)
            {
                Console.WriteLine($"{1}부터{z1}까지의 합은{z2}이고, 목표치 {z}이상을 달성했습니다. ");
                break;
            }
        }
        //================================================================
        for (int i = 1; i < 10; i++)
        {
            if (i % 5 == 0)
            {
                //break; 멈춤
                continue; //건너뜀

            }
            Console.WriteLine(i);
        }
        //================================================================
        Console.WriteLine("시작");
    Start:
        Console.WriteLine("0,1,2 중 택1");
        int chapter = Convert.ToInt32(Console.ReadLine());
        if (chapter == 0)
        {
            goto Chapter1;
        }
        else if (chapter == 1)
        {
            goto Chapter2;
        }
        else
        {
            goto End;
        }
    Chapter1:
        {
            Console.WriteLine("chapter1이다.");
        }
    Chapter2:
        {
            Console.WriteLine("chapter2이다.");
        }

        goto Start;

    End:
        {
            Console.WriteLine("종료한다.");
        }
    }
}

 