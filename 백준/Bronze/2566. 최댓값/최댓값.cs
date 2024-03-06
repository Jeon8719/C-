int[][] A = new int[9][];
List<int> B = new List<int>();
List<int> B1 = new List<int>();

for (int i = 0; i < 9; i++)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    A[i] = a;
    B.Add(a.Max());
    B1.Add(Array.IndexOf(a, a.Max()));
}
Console.WriteLine(B.Max());
int index = B.IndexOf(B.Max());
Console.Write(index+1);
Console.Write(" ");
Console.Write(B1[index]+1);