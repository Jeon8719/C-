using System.Text;

int A = Convert.ToInt32(Console.ReadLine());
StringBuilder sb = new();
for (int i = 1; i <= A; i++) 
{
    sb.AppendLine(i.ToString());
}
Console.WriteLine(sb);