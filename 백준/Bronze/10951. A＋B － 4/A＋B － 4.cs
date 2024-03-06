while (true)
{
    string str = Console.ReadLine();
    if (str == null) break;
    int[] arry = Array.ConvertAll(str.Split(), int.Parse);
    Console.WriteLine(arry[0] + arry[1]);
}