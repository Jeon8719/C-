int[] arry = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (arry[0] > arry[1])
{
    Console.WriteLine(">");
}
else if (arry[0] < arry[1])
{
    Console.WriteLine("<");
}
else
{
    Console.WriteLine("==");
}

