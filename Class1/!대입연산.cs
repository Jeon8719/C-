class Program
{
    static void Main(string[] args)
    {
        //할당대입연산
        int a = 90;
        int b = 90;
        int c = 10;
        int d = 20;
        int e = 30;
        int f = 2;
        a = a + 10;
        a += 10;
        b -= 10;
        c *= 2;
        d /= 10;
        e %= 4;
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"d = {d}");
        Console.WriteLine($"e = {e}"); 
    }
}

