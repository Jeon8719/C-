using System.Text;

StringBuilder sb = new StringBuilder();
while(true)
{
    try 
    {
        int n = int.Parse(Console.ReadLine());
        int length = (int)Math.Pow(3, n);
        char[] cantorSet = new char[length];
        for (int i = 0; i < length; i++)
        {
            cantorSet[i] = ' ';
        }
        GenerateCantorSet(cantorSet, 0, length - 1, n);
        sb.Append(cantorSet);
        sb.AppendLine();
    }
    catch
    {
        break;
    }
    

}

Console.WriteLine(sb.ToString());


void GenerateCantorSet(char[] cantorSet, int start, int end, int iteration)
{
    if (iteration == 0)
    {
        cantorSet[start] = '-';
        return;
    }

    int interval = (end - start + 1) / 3;

    GenerateCantorSet(cantorSet, start, start + interval - 1, iteration - 1);
    GenerateCantorSet(cantorSet, end - interval + 1, end, iteration - 1);
}

