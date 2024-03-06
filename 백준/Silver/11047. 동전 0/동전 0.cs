using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int[] NK = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = NK[0];
int K = NK[1];
int[] coin = new int[N];
int count = 0;
for(int i = 0; i < N; i++)
{
    coin[i] = int.Parse(sr.ReadLine());    
}
Array.Reverse(coin);
while(K != 0)
{
    for(int i = 0; i < coin.Length; i++)
    {
        if (coin[i] > K) { }
        else
        {            
            count += K / coin[i];
            K = K % coin[i];
            i = 0;
        }        
    }
}
sb.AppendLine(count.ToString());
sw.Write(sb.ToString());
sr.Close();
sw.Close();

