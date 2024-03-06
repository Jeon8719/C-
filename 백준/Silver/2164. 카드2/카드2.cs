int a = int.Parse(Console.ReadLine());
Queue<int> q = new Queue<int>();
if (a == 1) Console.WriteLine(1);
else
{
    for (int i = 1; i <= a; i++)
    {
        q.Enqueue(i);
    }
    while (q.Count > 0)
    {
        q.Dequeue();
        q.Enqueue(q.Peek());
        q.Dequeue();
        if (q.Count == 1) break;
    }
    Console.WriteLine(q.Peek());
}    
