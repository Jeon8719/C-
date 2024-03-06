int a = int.Parse(Console.ReadLine());
int count = a;
for (int i = 0; i < a; i++)
{
    char[] b = Console.ReadLine().ToCharArray();
    if (b.Length > 2)
    {
        List<char> list = new List<char>();
        List<char> list2 = new List<char>();
        for (int j = 0; j < b.Length; j++)
        {
            list.Add(b[j]);
        }
        while (list.Count > 0)
        {
            if (list.Count == 1)
            {
                if (list2.Contains(list[0]))
                {
                    count--;
                    break;
                }
                else
                {
                    break;
                }
            }
            if (list2.Contains(list[0]))
            {
                count--;
                break;
            }
            else if (list[0] == list[1])
            {
                list.RemoveAt(0);
            }
            else
            {
                list2.Add(list[0]);
                list.RemoveAt(0);
            }
        }    
    }


}
Console.WriteLine(count);