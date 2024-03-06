int N = int.Parse(Console.ReadLine());
double[] score = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
double M = score.Max();
double[] newScore = new double[N];
double result = 0;
for(int i = 0; i < N; i++)
{
    newScore[i] = (score[i] * 100) / M;
    result += newScore[i];
}
string print = string.Format("{0}", result / N);
Console.WriteLine(print);
