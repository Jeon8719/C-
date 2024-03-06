internal class Program
{
    /// <summary>
    /// 트리 생성 
    /// </summary>
    static int N;
    struct TreeNode
    {
        public int Left;
        public int Right;
    }
    static TreeNode[] Tree = new TreeNode[26];

    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());

        for (int counter = 1; counter <= N; ++counter)
        {
            string[] inputs = Console.ReadLine().Split();

            int nodeIndex = GetNodeIndex(inputs[0]);
            int leftIndex = GetNodeIndex(inputs[1]);
            int rightIndex = GetNodeIndex(inputs[2]);

            Tree[nodeIndex].Left = leftIndex;
            Tree[nodeIndex].Right = rightIndex;
        }

        PreOrder(0);
        Console.WriteLine();
        MiddleOrder(0);
        Console.WriteLine();
        BackOrder(0);
    }
    /// <summary>
    /// 전위,중위,후위 순회
    /// </summary>
    /// <param name="node"></param>
    static void PreOrder(int node)
    {
        if (node == None)
        {
            return;
        }

        Console.Write(GetName(node)); // 자신을 방문한다.
        PreOrder(Tree[node].Left); // 왼쪽 자식을 방문한다.
        PreOrder(Tree[node].Right); // 오른쪽 자식을 방문한다.
    }
    static void MiddleOrder(int node)
    {
        if (node == None)
        {
            return;
        }
        MiddleOrder(Tree[node].Left); // 왼쪽 자식을 방문한다.
        Console.Write(GetName(node)); // 자신을 방문한다.
        MiddleOrder(Tree[node].Right); // 오른쪽 자식을 방문한다.
    }
    static void BackOrder(int node)
    {
        if (node == None)
        {
            return;
        }
        BackOrder(Tree[node].Left); // 왼쪽 자식을 방문한다.
        BackOrder(Tree[node].Right); // 오른쪽 자식을 방문한다.
        Console.Write(GetName(node)); // 자신을 방문한다.
        
    }

    const int None = -1;
    static int GetNodeIndex(string node)
    {
        if (node == ".")
        {
            return None;
        }

        return Convert.ToInt32(node[0]) - Convert.ToInt32('A');
        //입력 받은 ASCII코드를 Int로 변환
    }

    static char GetName(int index)
    {
        return Convert.ToChar(index + Convert.ToInt32('A'));
        //Int를 다시 ASCII코드로 반환
    }

}
