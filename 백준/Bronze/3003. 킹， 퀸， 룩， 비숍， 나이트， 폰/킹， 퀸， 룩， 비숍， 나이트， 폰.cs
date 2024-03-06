int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = {1,1,2,2,2,8};
int[] c = new int[6];
for (int i = 0; i < 6; i++)
{
    c[i] = b[i] - a[i];
    Console.Write(c[i]);
    Console.Write(" ");
}