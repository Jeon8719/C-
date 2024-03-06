using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

       
        bool pass = false;
        while (true) 
        {
            char[] a = sr.ReadLine().ToCharArray();
            if (a[0] == '0') break;
            char[] b = a.Reverse().ToArray();
            
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] == b[j])
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                    break;
                }

            }
            if (pass == true) sb.AppendLine("yes");
            else sb.AppendLine("no");

        }

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
