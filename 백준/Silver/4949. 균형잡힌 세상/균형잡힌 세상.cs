using System.Text;
class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        Stack<char> stack = new Stack<char>();
        while (true)
        {
            string a = sr.ReadLine();
            if (a == ".") break;
            for(int i = 0; i < a.Length; i++)
            {
                char[] b = a.ToCharArray();
                if (b[i] == '(' )
                {
                    stack.Push('(');

                }
                else if (b[i] == '[' )
                {
                    stack.Push('[');
 
                }
                if (b[i] == ')'&& stack.Count != 0)
                {
                   
                    if (stack.First() == '(') stack.Pop();
                    else break;

                }
                else if (b[i] == ')' && stack.Count == 0)
                {
                    stack.Push(')');
                }
                else if (b[i] == ']' && stack.Count != 0)
                {
                    
                    if (stack.First() == '[') stack.Pop();
                    else break;
                }
                else if (b[i] == ']' && stack.Count == 0)
                {
                    stack.Push(']');
                }
            }
            if (stack.Count == 0) sb.AppendLine("yes");
            else sb.AppendLine("no");
            stack.Clear();
            
        }
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
