StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
Stack<int> stack = new Stack<int>();

int a = int.Parse(sr.ReadLine());
for (int i = 0; i < a; i++)
{
    string[] input = sr.ReadLine().Split();
    switch (input[0])
    {
        case "push":
            Push(int.Parse(input[1]));
            break;
        case "pop":
            Pop();
            break;
        case "size":
            Size();
            break;
        case "empty":
            Empty();
            break;
        case "top":
            Top();
            break;
        default:
            break;
    }



}

void Push(int value)
{
    stack.Push(value);
}
void Pop()
{
    if (stack.Count > 0)
    {
        sw.WriteLine(stack.Pop());
        return;
    }
    sw.WriteLine(-1);

}
void Size()
{
    sw.WriteLine(stack.Count);
}
void Empty()
{
    if (stack.Count != 0) sw.WriteLine(0);
    else sw.WriteLine(1);
}
void Top()
{
    if (stack.Count > 0) sw.WriteLine(stack.Peek());
    else sw.WriteLine(-1);
}

sw.Close();
sr.Close();