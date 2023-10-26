using System;
class Program
{


    static void Main(string[] args)
    {

        //배열 : 같은 형태의 데이터를 묶어서, 순차적으로 정렬한 자료구조입니다.
        //배열의 구성 요소 
        //1. 배열의 index : 배열 안에 저장되어있는 값에 대한 위치를 알려주는 정수형 데이터로
        //                 1번이 아닌 0번부터 카운트.
        //                 0부터 배열의 길이 -1까지 제공.

        //2. 배열의 element : 배열 안에 있는 값


        //배열(array) 만드는 방법
        //자료형[] 배열명 = new 자료형[배열의 길이(데이터 개수)];

        int[] a = new int[4];//0부터 카운트 하여 배열 범위 = 0~3

        //index 사용 방법
        //index[] = element;
        a[0] = 7;
        Console.WriteLine(a[0]); //설정한 값 생성
        Console.WriteLine(a[1]); //값이 없으면 기본 값(0)이 생성
                                 //Console.WriteLine(a[4]); //배열 범위 이탈 시 예외 발생

        //배열을 값을 넣으면서 만드는 방법
        //자료형[] 배열명 = new 자료형[] {요소1, 요소2, .....};
        //[]안에 숫자를 입력하지 않으면 자동으로 요소만큼 배열 생성
        string[] items = new string[] { "사과", "딸기", "바나나", "키위", "망고" };
        //배열출력 문법
        //foreach는 배열의 형태에서 낱개의 데이터를 접근하는 문법
        //foreach(자료형 변수명 in 배열명)
        //{

        //}
        //배열 안에 있는 변수의 개수만큼 반복이 진행되는 코드
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        //반복문 for문을 이용한 배열 출력
        //i++는 i의 값을 1씩 증가 시키는 코드

        int[] prices = new int[] { 1000, 2000, 3000 };

        for (int i = 0; 1 < 3; i++)
        {                                                  // # = 안에 값이 없을 경우 0을 넣음
            Console.WriteLine($"{items[i]} : {prices[i]: #,000} 원");
        }
        //반복문 for의 실행순서
        //1. int 1 = 0; (최초 1회)
        //2. 1 < 3에 대한 결과를 확인
        //2-1. (조건이 맞을 경우) Console.WriteLine 진행
        //2-2. 1++에 의해 1는 0 -> 1
        //조건이 맞지 않을 때까지 2 ~ 2-2까지 작업 반복
        //3. (조건이 맞지 않을 경우) 반복문 종료
    }
}