using System.Text;

StringBuilder sb = new StringBuilder();
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Queue<int> q = new Queue<int>();
for (int i = 1; i <= a[0]; i++)
{
    q.Enqueue(i);
}
int count = a[1];
int num = 1;
while (q.Count > 0)
{
    if (count == num)
    {
        if (q.Count == 1) sb.Append(q.Dequeue().ToString());
        else sb.Append(q.Dequeue().ToString()+", ");
        num = 1;
    }
    else
    {
        q.Enqueue(q.Peek());
        q.Dequeue();
        num++;
    }
}
Console.Write("<");
Console.Write(sb.ToString());
Console.Write(">");