using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (a[0] == 0 && a[1] == 0 && a[2] == 0)
    {
        break;
    }
    else
    {
       Array.Sort(a);
        if (a[2] < a[0] + a[1])
        {
            if (a[0] == a[1] && a[1] == a[2])
            {
                sb.AppendLine("Equilateral");
            }
            else if (a[0] != a[1] && a[0] != a[2] && a[1] != a[2])
            {
                sb.AppendLine("Scalene");
            }
            else
            {
                sb.AppendLine("Isosceles");
            }
            
        }
        else
        {
            sb.AppendLine("Invalid");
        }

    }
}
Console.WriteLine(sb.ToString());