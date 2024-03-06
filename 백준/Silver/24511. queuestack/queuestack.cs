using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        //N&M = 100000
        //B&C = 1000000000
        int N = int.Parse(sr.ReadLine());
        int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int[] B = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int M = int.Parse(sr.ReadLine());
        int[] C = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        List<int> list = new List<int>();
        for (int i = 0; i < N; i++)
        {
            if (A[i] == 0)
            {
                list.Add(B[i]);
            }
        }
        list.Reverse();
        for (int i = 0;i < M; i++) 
        {
            list.Add(C[i]);
            sb.Append(list[i]+" ");
        }
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
