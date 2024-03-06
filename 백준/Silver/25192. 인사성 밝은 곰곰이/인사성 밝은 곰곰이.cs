int N = int.Parse(Console.ReadLine());
HashSet<string> list = new HashSet<string>();
int C = 0;
for (int i = 0; i < N; i++)
{
    string A = Console.ReadLine();
    if (list.Contains("ENTER"))
    {
        if(A == "ENTER")
        {
            list.Clear();
            list.Add(A);
        }   
    }
    if (!list.Contains(A))
    {
        list.Add(A);
        C++;
    }
}
Console.WriteLine(C-1);