using System.Text;
class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        Stack<int> stack = new Stack<int>();
        int a = int.Parse(sr.ReadLine());
        for (int i = 0; i < a; i++)
        {
            int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            switch (b[0])
            {
                case 1:
                    stack.Push(b[1]);
                    break;
                case 2:
                    if (stack.Count > 0)
                    {
                        
                        sb.AppendLine(stack.Pop().ToString());

                    }
                    else
                    {
                        sb.AppendLine("-1".ToString());
                    }
                        break;
                case 3:
                    sb.AppendLine(stack.Count.ToString());
                    break;
                case 4:
                    if (stack.Count > 0) sb.AppendLine("0".ToString());
                    else sb.AppendLine("1".ToString());
                    break;
                case 5:
                    if (stack.Count > 0)
                    {
                        sb.AppendLine(stack.First().ToString());
                    }
                    else
                    {
                        sb.AppendLine("-1".ToString());
                    }
                    break;

            }
        }

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
