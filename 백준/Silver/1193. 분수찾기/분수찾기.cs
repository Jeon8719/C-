/*
1 =1/1
2 =1/2
3 =2/1
4 =3/1
5 =2/2
6 =1/3
7 =1/4
8 =2/3
9 =3/2
14 =2/4
우로 1칸
좌하로 끝까지 i/1
하로 1칸
우상 끝까지 1/j
*/

int a = int.Parse(Console.ReadLine());
int Y = 1; int X = 1;
int move = 0;

while (a > 1)
{
    switch (move)
    {
        case 0:
            X++;
            a--;
            move++;
            break;
        case 1:
            while (X > 1 && a > 1)
            {
                a--;
                Y++;
                X--;
            }
            move++;
            break;
        case 2:
            Y++;
            a--;
            move++;
            break;
        case 3:
            while (Y > 1 && a > 1)
            {
                a--;
                X++;
                Y--;
            }
            move = 0;
            break;
    }
}
Console.WriteLine($"{Y}/{X}");