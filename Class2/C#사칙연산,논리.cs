using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 20, c = 5;
        int f, g, answer;
        bool d, e, h, i, value;
        value = false;

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b); //몫
        Console.WriteLine(a % b); //나머지

        d = a >= b; //false
        Console.WriteLine(d);
        e = a != b; //true 
        Console.WriteLine(e);
        f = a += b; //30
        Console.WriteLine(f);
        g = a %= b; //10
        Console.WriteLine(g);
        h = (a == b) && (b <= c);//false 
        Console.WriteLine(h);
        i = (a != b) || (b < c);//true
        Console.WriteLine(i);
        answer = value ? a : b;//3항 연산 맞으면 a 틀리면 b
        Console.WriteLine(answer);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"++a = {++a}"); //1+a
        Console.WriteLine($"a++ = {a++}"); //a+1
        Console.WriteLine($"a = {a}"); //1+a+1



    }
}

 