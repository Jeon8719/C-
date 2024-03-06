public class Program
{
    static void Main(string[] args)
    {
        int money = 0;
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if (a[0] == a[1] && a[1] == a[2]) money = 10000 + (a[0] * 1000);
        else if (((a[0] == a[1] && a[1] != a[2])) || (a[0] == a[2] && a[2] != a[1]))
            money = 1000 + (a[0] * 100);
        else if (a[1] == a[2] && a[2] != a[0])
            money = 1000 + (a[1] * 100);
        else if (a[0] != a[1] && a[1] != a[2])
            money = a.Max() * 100;
        Console.WriteLine(money);   // 필드
    }

}