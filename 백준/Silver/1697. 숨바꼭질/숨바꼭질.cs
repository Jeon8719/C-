string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int K = int.Parse(input[1]);
Queue<int> queue = new Queue<int>();
queue.Enqueue(N);
bool[] isVisted = new bool[100001];
int result = 0;

while (queue.Count > 0)
{
    int Lv = queue.Count;
    bool isFound = false;

    for (int i = 0; i < Lv; i++)
    {
        int x = queue.Dequeue();
        if (x == K)
        {
            isFound = true;
            break;
        }
        if (isVisted[x])
        {
            continue;
        }
        isVisted[x] = true;
        if (x > 0 && isVisted[x - 1] == false)
        {
            queue.Enqueue(x - 1);
        }
        if (x < 100000 && isVisted[x + 1] == false)
        {
            queue.Enqueue(x + 1);
        }
        if (x * 2 <= 100000 && isVisted[x * 2] == false)
        {
            queue.Enqueue(x * 2);
        }
    }
    if(isFound == true)
    {
        break;
    }
    result++;
}
Console.WriteLine(result);