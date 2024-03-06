StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine().Split();
int K = int.Parse(inputs[0]);
int N = int.Parse(inputs[1]);
int min = int.MaxValue;
int[] lans = new int[K];
for (int i = 0; i < K; i++)
{
    int lan = int.Parse(sr.ReadLine());
    lans[i] = lan;
    if (lan < min)
    {
        min = lan;
    }
}
sr.Close();
///입력 받고
long s = 1;
long e = lans.Max();
long result = 0;
while (s <= e)
{
    long m = s + (e-s) / 2;
    long counter = 0;
    foreach (int lan in lans)
    {
        counter += lan / m;
    }
    if (counter < N)
    {
        e = m - 1;
    }
    else
    {
        if (result < m)
        {
            result = m;
        }
        s = m + 1;
    }

}
sw.WriteLine(result);
sw.Close();