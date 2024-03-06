int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if (A > 0 && B > 0)
{
    Console.WriteLine("1");
}
else if (A < 0 && B > 0)
{
    Console.WriteLine("2");
}
else if (A < 0 && B < 0)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("4");
}

