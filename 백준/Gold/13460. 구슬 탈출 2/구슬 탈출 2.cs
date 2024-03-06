using System;
using System.Collections.Generic;

class Program
{
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    static void Main()
    {
        int[] size = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        char[][] board = new char[size[0]][];

        for (int i = 0; i < size[0]; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        int result = Solve(board);
        Console.WriteLine(result);
    }

    static int Solve(char[][] board)
    {
        Queue<Tuple<int[], int[]>> queue = new Queue<Tuple<int[], int[]>>();
        HashSet<string> visited = new HashSet<string>();

        int[] red = new int[2];
        int[] blue = new int[2];
        int[] hole = new int[2];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == 'R')
                {
                    red = new int[] { i, j };
                }
                else if (board[i][j] == 'B')
                {
                    blue = new int[] { i, j };
                }
                else if (board[i][j] == 'O')
                {
                    hole = new int[] { i, j };
                }
            }
        }

        queue.Enqueue(new Tuple<int[], int[]>(red, blue));
        visited.Add($"{red[0]} {red[1]} {blue[0]} {blue[1]}");

        int moves = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                Tuple<int[], int[]> current = queue.Dequeue();
                int[] currentRed = current.Item1;
                int[] currentBlue = current.Item2;

                if (currentRed[0] == hole[0] && currentRed[1] == hole[1])
                {
                    return moves;
                }

                for (int dir = 0; dir < 4; dir++)
                {
                    int[] nextRed = Move(currentRed, dir, board);
                    int[] nextBlue = Move(currentBlue, dir, board);

                    bool redInHole = board[nextRed[0]][nextRed[1]] == 'O';
                    bool blueInHole = board[nextBlue[0]][nextBlue[1]] == 'O';

                    if (blueInHole)
                    {
                        continue; // 파란 구슬이 구멍에 빠지면 안 됨
                    }

                    if (nextRed[0] == nextBlue[0] && nextRed[1] == nextBlue[1])
                    {
                        // 빨간 구슬과 파란 구슬이 같은 위치에 있으면 이동 거리 비교
                        int redDistance = Math.Abs(currentRed[0] - nextRed[0]) + Math.Abs(currentRed[1] - nextRed[1]);
                        int blueDistance = Math.Abs(currentBlue[0] - nextBlue[0]) + Math.Abs(currentBlue[1] - nextBlue[1]);

                        if (redDistance > blueDistance)
                        {
                            nextRed[0] -= dx[dir];
                            nextRed[1] -= dy[dir];
                        }
                        else
                        {
                            nextBlue[0] -= dx[dir];
                            nextBlue[1] -= dy[dir];
                        }
                    }

                    if (!visited.Contains($"{nextRed[0]} {nextRed[1]} {nextBlue[0]} {nextBlue[1]}"))
                    {
                        queue.Enqueue(new Tuple<int[], int[]>(nextRed, nextBlue));
                        visited.Add($"{nextRed[0]} {nextRed[1]} {nextBlue[0]} {nextBlue[1]}");
                    }
                }
            }

            moves++;

            if (moves > 10)
            {
                return -1; // 10번 이상 움직여도 목표에 도달하지 못하면 -1 반환
            }
        }

        return -1; // 큐가 비어도 목표에 도달하지 못하면 -1 반환
    }

    static int[] Move(int[] ball, int dir, char[][] board)
    {
        int x = ball[0];
        int y = ball[1];

        while (board[x + dx[dir]][y + dy[dir]] != '#')
        {
            x += dx[dir];
            y += dy[dir];

            if (board[x][y] == 'O')
            {
                break;
            }
        }

        return new int[] { x, y };
    }
}
