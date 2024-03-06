int[] arry = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (90 <= arry[0] && arry[0] <= 100)
{
    Console.WriteLine("A");
}
else if (80 <= arry[0] && arry[0] <= 89)
{
    Console.WriteLine("B");
}
else if (70 <= arry[0] && arry[0] <= 79)
{
    Console.WriteLine("C");
}
else if (60 <= arry[0] && arry[0] <= 69)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}

