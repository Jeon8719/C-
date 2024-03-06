StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

int N = int.Parse(sr.ReadLine());
List<int> list = new List<int>(Array.ConvertAll(sr.ReadLine().Split(), int.Parse));

int M = int.Parse(sr.ReadLine());
List<int> list2 = new List<int>(Array.ConvertAll(sr.ReadLine().Split(), int.Parse));

list.Sort();

foreach (int n in list2)
{
    int result = list.BinarySearch(n);
    if (result < 0) sw.WriteLine(0);
    else sw.WriteLine(1);

}
sw.Close();
sr.Close();
