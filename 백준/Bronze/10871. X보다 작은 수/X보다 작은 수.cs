/*
 * A에 입력받은 10만큼 생성
 int[] a = {1, 10, 4, 9, 2, 3, 8, 5, 7, 6}
B에 입력받은 5보다 작은 값을
작은 순서대로 결과에 출력
 */
int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//input[0] = 10
//input[1] = 5
int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//input2[] = 1 10 4 9 2 3 8 5 7 6

foreach (int num in input2)
{
    if (num < input[1])
    {
        Console.Write(num + " ");
    }

}