StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
Stack<int> stack = new Stack<int>();

int a = int.Parse(sr.ReadLine());
for (int i = 0; i < a; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    switch (input[0])
    {
        case 0:
            Pop();
            break;
        default:
            Push(input[0]);
            break;
    }
}
sw.WriteLine(stack.Sum());
void Push(int value)
{
    stack.Push(value);
}
void Pop()
{
    stack.Pop();

}


sw.Close();
sr.Close();