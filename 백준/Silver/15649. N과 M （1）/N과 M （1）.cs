using System.Text;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StringBuilder sb = new StringBuilder();

string[] input = sr.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = i + 1;
}

int[] result = new int[m];
bool[] visited = new bool[n];

Permutation(arr, result, visited, 0, m);
sw.WriteLine(sb.ToString());
sr.Close();
sw.Close();

void Permutation(int[] arr, int[] result, bool[] visited, int depth, int m)
{
    if (depth == m)
    {
        foreach (int num in result)
        {
            sb.Append(num + " ");
        }
        sb.AppendLine();
        return;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (!visited[i])
        {
            visited[i] = true;
            result[depth] = arr[i];
            Permutation(arr, result, visited, depth + 1, m);
            visited[i] = false;
        }
    }
}