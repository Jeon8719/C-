int N = int.Parse(Console.ReadLine());
HashSet<string> list = new HashSet<string>();
list.Add("ChongChong");
int Count = 1;
for(int i  = 0; i < N; i++)
{
    string[] Meeting = Console.ReadLine().Split();
    if (list.Contains(Meeting[0]) && !list.Contains(Meeting[1]))
    {
        list.Add(Meeting[1]);
        Count++;
    }
    else if (list.Contains(Meeting[1]) && !list.Contains(Meeting[0]))
    {
        list.Add(Meeting[0]);
        Count++;
    }
}
Console.WriteLine(Count);

