using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (a[0]==0&& a[1] == 0)
    {
        break;
    }
    else
    {
        if (a[0] / a[1] != 0 && a[0] % a[1] == 0 ) 
        {
            sb.AppendLine("multiple");
            
        }
        else if (a[0] / a[1] == 0 && a[0] % a[1] != 0)
        {
            sb.AppendLine("factor");
        }
        else { sb.AppendLine("neither"); }
    }
}
Console.WriteLine(sb.ToString());
