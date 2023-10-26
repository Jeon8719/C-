class Program
{
    static void Main(string[] args)
    {
        //증감 연산
        int a = 1;
        Console.WriteLine($"a={a}");
        Console.WriteLine($"++a ={++a}");
        Console.WriteLine($"a++ ={a++}");
        Console.WriteLine($"a={a}");

        int b = 2;
        int sum = a + b;
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a + ++b = {a + ++b}");
        Console.WriteLine($"a + b++ = {a + b++}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"--b = {--b}");
        Console.WriteLine($"b-- = {b--}");
        Console.WriteLine($"b = {b}");
        int a = 8;
        int b = 0, c = 0, d = 0, e = 0;
        b = a++;
        Console.WriteLine("b = " + b);
        c = ++a;
        d = a--;
        e = --a;

        Console.WriteLine("a = " + a);
        Console.WriteLine("a++ = " + b);
        Console.WriteLine("++a = " + c);
        Console.WriteLine("a-- = " + d);
        Console.WriteLine("--a = " + e);
        Console.ReadLine();
    }
}

