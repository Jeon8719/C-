using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new();
List<int> _container = new List<int>();
int N = int.Parse(sr.ReadLine());

int[] a = new int[N];
for (int i = 0; i < N; i++)
{
  
    int input = int.Parse(sr.ReadLine());
    if (input == 0) sb.AppendLine(Dequeue().ToString());
    else Enqueue(input);
}
sw.WriteLine(sb);
sw.Close();
sr.Close();

void Enqueue(int value)
{
    _container.Add(value);

    int current = _container.Count;
    while (true)
    {
        if (current == 1)
        {
            break;
        }

        int parent = current / 2;
        if (_container[parent - 1] <= _container[current - 1])
        {
            break;
        }

        Swap(parent - 1, current - 1);

        current = parent;
    }
}

int Dequeue()
{
    if (_container.Count == 0)
        return 0;
    int result = _container[0];
    _container[0] = _container[_container.Count - 1];
    _container.RemoveAt(_container.Count - 1);

    int current = 1;
    int containerSize = _container.Count;
    while (true)
    {
        int left = current * 2;
        int right = left + 1;

        if (left > containerSize)
        {
            break;
        }

        int childToBeSwapped = left;
        if (right <= containerSize && _container[right - 1] < _container[left - 1])
        {
            childToBeSwapped = right;
        }

        if (_container[current - 1] < _container[childToBeSwapped - 1])
        {
            break;
        }

        Swap(childToBeSwapped - 1, current - 1);

        current = childToBeSwapped;
    }

    return result;
}

int Peek()
{
    return _container[0];
}

void Swap(int a, int b)
{
    int temp = _container[a];
    _container[a] = _container[b];
    _container[b] = temp;
}