using System;

class Program
{
    static int CalculateSumOfDigits(int number) // a+ b + c
    {
        // 숫자의 각 자리 숫자를 더하는 함수
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static int FindSmallestConstructor(int decompositionSum)
    {
        // 분해합에 대한 최소 생성자를 찾는 함수
        for (int candidate = 1; candidate <= decompositionSum; candidate++)
        {//candidate=abc
            if (decompositionSum == candidate + CalculateSumOfDigits(candidate))
            {
                return candidate;
            }
        }
        return -1; // 적절한 생성자를 찾지 못한 경우
    }

    static void Main()
    {
        // 사용자로부터 분해합 입력 받기
        int inputDecompositionSum = int.Parse(Console.ReadLine());

        // 최소 생성자 찾기
        int smallestConstructor = FindSmallestConstructor(inputDecompositionSum);

        // 결과 출력
        if (smallestConstructor != -1)
        {
            Console.WriteLine(smallestConstructor);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
