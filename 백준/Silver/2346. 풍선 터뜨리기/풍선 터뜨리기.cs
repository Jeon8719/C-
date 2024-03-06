using System.Text;

StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new StringBuilder();

int num = int.Parse(sr.ReadLine());
bool[] savebool = new bool[num];
int[] distanceList = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
int c = 0;
sb.Append(string.Format("1"));
savebool[0] = true;
checkPath(0);
sw.Write(sb.ToString());
sr.Close();
sw.Close();
void pcheck(int count, int distance)
{
    c++;
    for (int j = 1; j <= distance; j++)
    {
        do
        {
            count++;
            if (count > num - 1)
            {
                count = 0;
            }
        }
        while (savebool[count]);
    }
    sb.Append(string.Format(" {0}", count + 1));
    checkPath(count);
}
void mcheck(int count, int distance)
{
    c++;
    for (int j = 1; j <= -1 * distance; j++)
    {
        do
        {
            count--;
            if (count < 0)
            {
                count = num - 1;
            }
        }
        while (savebool[count]);
    }
    sb.Append(string.Format(" {0}", count + 1));
    checkPath(count);
}
void checkPath(int count)
{
    savebool[count] = true;
    if (c == num - 1)
    {
        // Finish
    }
    else
    {
        if (distanceList[count] > 0)
        {
            pcheck(count, distanceList[count]);
        }
        else
        {
            mcheck(count, distanceList[count]);
        }
    }
}
