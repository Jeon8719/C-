
using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
Stack<int> stack = new Stack<int>();
stack.Push(0);
int N = int.Parse(sr.ReadLine());
int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    arr[i] = int.Parse(sr.ReadLine());
}


int num = 0;
int nowhead = 1;
while (true)
{
    int head = arr[num];
    if (stack.Peek() == head)
    {
        stack.Pop();
        sb.AppendLine("-");
        num++;
    }
    else
    {
        
        stack.Push(nowhead);
        sb.AppendLine("+");
        nowhead++;
    }
    if (num > N-1) break;
    if (stack.Peek() > head)
    {
        sb.Clear();
        sb.AppendLine("NO");
        break;
    }
}
sw.WriteLine(sb.ToString());
sr.Close();
sw.Close();

