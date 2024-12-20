using System;
using System.Threading;

namespace Day23_Project_Study_4
{
    //delegate int Calculator(int a, int b);  //반환형 인트, 인자값 숫자 2개 받는 형식
    delegate void CallbackDelegate(string message);  //인자값 스트링
    delegate bool CompareDelegate(int a, int b);  //반환형 인트, 인자값 숫자 2개 받는 형식

    class Program
    {
        /*
        static void HeavyWork(CallbackDelegate callback)
        {
            Console.WriteLine("뭔가 시간 걸리는 게임 기능");
            Thread.Sleep(1000); //위 작업 1초 걸렸다고 가정
            callback("작업이 완료 되었습니다");
        }*/

        static void Sort(int[] array, CompareDelegate compare)
        {
            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (!compare(array[j], array[j+1])) //여기만 다름
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            /*
            //람다식
            //익명 함수: 이름이 없는 함수 보통 짧은 코드의 델리게이트 대입 등에 사용
            // 장점: 코드 간결해짐
            // 매서드로 빼기 좀 애매함,,,그런거 람다식으로 하면 편함

            Calculator add;  //델리게이트 하나 생성

            // 익명함수 만드는 법은 아래와 같음
            // (입력 매개변수) = > {실행 코드}
            add = (x,y) => x + y;

            Calculator multiply = (x,y) => x * y;

            Console.WriteLine($"5+3={add(5, 3)}");
            Console.WriteLine($"5*3={multiply(5, 3)}");*/

            //콜백 함수: 콜백 호출, (나중에 뭔가 하겠다)
            //콜백: 특정 작업이 완료된 후에 호출되는 메서드
            //예를 들어, 어떤 동작을 실행한 뒤, 그 결과를 바탕으로 다른 작업을 수행하고 싶을 때

            //예시: 유니티에서 버튼 클릭, 키 입력(문가 처리를 하고 그에 따른 행동을 지시할 때)
            //알고리즘 구현 시, 동작을 유연하게 오름차순, 내림차순으로 바꿀 때
            // + 나중에 네트워크 같은 비동기 작업 때 콜백 도배되어있음

            //HeavyWork(OnWorkCompleted);
            //Console.WriteLine("메인 메서드 작업중임");

            /*
            Console.WriteLine("타이머 시작");
            //3초후 콜백 메서드 호출하는 기능
            Timer timer = new Timer(Callback, null, 3000, Timeout.Infinite);
            Console.WriteLine("이게 먼저 실행 될까?");
            Console.ReadLine( ); //콘솔창 잠시 정지
            */

            //진짜 유의미한 콜백 보겠음
            int[] numbers = { 5, 3, 8, 1, 2 };

            //오름차순 정렬, 람다식 응용
            Sort(numbers, (a, b) => a < b);
            Console.WriteLine("오름차순: "+ string.Join(", ", numbers));

            //내림차순 정렬, 람다식 응용
            Sort(numbers, (a, b) => a > b);
            Console.WriteLine("오름차순: " + string.Join(", ", numbers));

        }

        /*
        static void OnWorkCompleted(string message)
        {
            Console.WriteLine($"콜백 호출: {message}");
        }*/

        /*
        static void Callback(object State)
        {
            Console.WriteLine("3초 후에 실행될 메서드!!!");
        }*/


    }
}
