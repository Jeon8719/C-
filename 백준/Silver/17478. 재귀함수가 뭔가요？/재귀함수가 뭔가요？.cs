int a = Convert.ToInt32(Console.ReadLine());
int b = a;
Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
Recursive(a);
Close(a);

void Recursive(int a)
{
    if (a < 0) return;
    UnderLine(a); Console.WriteLine("\"재귀함수가 뭔가요?\"");
    if (a < 1) Middle(b);
    else
    {
        UnderLine(a); Console.WriteLine("\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
        UnderLine(a); Console.WriteLine("마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
        UnderLine(a); Console.WriteLine("그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
    }
    Recursive(a - 1);

}


void UnderLine(int a)
{
    int dif = b - a;
    while(dif-- > 0)
        Console.Write("____");
    

}
void Middle(int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.Write("____");
    }
    Console.WriteLine("\"재귀함수는 자기 자신을 호출하는 함수라네\"");

}


void Close(int a)
{
    if (a < 0) return;
    for (int i = 0; i < a; i++)
    {
        Console.Write("____");
    }
    Console.WriteLine("라고 답변하였지.");
    Close(a - 1);
}