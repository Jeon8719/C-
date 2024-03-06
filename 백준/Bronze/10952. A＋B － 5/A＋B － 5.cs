while(true)
{
    int[] arry = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (arry[0] == 0 && arry[1] == 0) break;
    Console.WriteLine(arry[0] + arry[1]);
}    