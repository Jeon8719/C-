class Program
{
    static void Main(string[] args)
    {
        //2항 연산
        int a = 20;
        int b = 20;
        //bool result = a > b;
        Console.WriteLine($"a>b = {a > b}");
        Console.WriteLine($"a>b = {a < b}");
        Console.WriteLine($"a>=b = {a >= b}");
        Console.WriteLine($"a<=b = {a <= b}");
        Console.WriteLine($"a==b = {a == b}");
        Console.WriteLine($"a!=b = {a != b}");
        Console.WriteLine($"a=b = {a = b}");
        //3항 연산
        int c= 1, d = 2;
        string right = "정답", wrong = "오답";
        bool value = c > d;
        string answer;
        answer = value ? right : wrong; // 
        Console.WriteLine(answer);

        Console.WriteLine("키를 입력하세요.");
        int height;
        height = Convert.ToInt32(Console.ReadLine());
        //var = 연산자를 알아서 정해줌
        var answer2 = (height >= 130) ? "탑승가능" : "보호자 동반";
        Console.WriteLine(answer2);
        Console.WriteLine(answer2.GetType());

        Console.WriteLine("숫자를 입력하세요.");
        int num = Convert.ToInt32(Console.ReadLine());
        int answer3;
        answer3 = num < 0 ? -(num) : num;
        Console.WriteLine($"{num}의 절대값: {answer3}");
    }
}

