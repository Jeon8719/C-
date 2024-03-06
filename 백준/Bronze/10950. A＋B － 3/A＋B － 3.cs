int T = Convert.ToInt32(Console.ReadLine());
for(int i  = 0; i < T; i++)
{
    int[] arry = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Console.WriteLine(arry[0] + arry[1]);
}
