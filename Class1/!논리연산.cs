class Program
{
    static void Main(string[] args)
    {
            //논리연산
            //And, Or, Xor, Not
            //And = && : 모두 true일 경우에만 true
            //Or = || : 하나라도 true면 true
            //Xor = ^  : 하나만 true 일 경우에만 true
            //Not = !  : true 면 false, false면 true
             bool x, y;
             x = 10 > 0;
             y = 10 < 0;
             Console.WriteLine($"x && y = {x && y}");
             Console.WriteLine($"x || y = {x || y}");
             Console.WriteLine($"!x = {!x}");
            Console.WriteLine("a값 입력");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b값 입력");
            int b = Convert.ToInt32(Console.ReadLine());
            bool answer = (a != 100) || (b != 200);
            bool result = answer ? true : false;
            Console.WriteLine($"{a != 100 || b != 200}");
            Console.WriteLine($"{result}");
    }
}

