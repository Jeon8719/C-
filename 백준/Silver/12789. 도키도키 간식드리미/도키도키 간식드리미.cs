using System.Text;
class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        List<int> list = new List<int>();
        Stack<int> stack2 = new Stack<int>();
        int a = int.Parse(sr.ReadLine());
        int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        foreach (int i in b)
        {
            list.Add(i);
        }
        int count = 1;
        while (list.Count > 0)
        {
            if (list.First() == count)
            {
                list.RemoveAt(0);
                count++;
            }
            else if (stack2.Count != 0 && stack2.First() == count)
            {
                stack2.Pop();
                count++;
            }
            else
            {
                stack2.Push(list[0]);
                list.RemoveAt(0);
            }            
        }
        while (stack2.Count > 0)
        {
            if (stack2.First() == count)
            {
                stack2.Pop();
                count++;
            }
            else
            {
                sb.AppendLine("Sad".ToString());
                break;
            }
        }
        if (stack2.Count == 0) sb.AppendLine("Nice".ToString());
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
