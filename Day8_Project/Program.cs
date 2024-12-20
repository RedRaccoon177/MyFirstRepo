using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Day8_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 전날 수업(배열)

            //int[] myNum;                // 여러개를 저장 원하면 배열을 고민한다.
            //myNum = null;               // null

            //myNum = new int[15];        // new를 통해서 선언(만들때는 []안에 갯수! 나중에 쓸때는 -1해서 사용.)
            //Console.WriteLine(myNum[14]);

            //float asd;
            //var myInput = int.Parse(Console.ReadLine());    //var에 대한 추가 공부 필요.
            //var secondInput = float.TryParse(Console.ReadLine(), out asd);


            //float asda; //하나만 저장할 것이다. 명백함
            //int asdb;
            //Random random;  //참조형
            //string myInputs;

            #endregion

            #region !, ToString, Thread.Sleep() => 천천히 출력
            //if (!isTrue)
            //{

            //}

            //if( 5 != 3) //!는 부정
            //{
            //    Console.WriteLine();
            //}

            //int myNumber = 10;
            //string myName = "asd";
            ////문자열을 정수로 바꾸려 할때, Parse, TryParse

            //myName = myNumber.ToString();  //ToString

            ////천천히 찍고 싶어요
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(500); //1초간 잠시 멈춤
            //}

            //int[][] a;  //가별 배열이라는 것도 존재한다. 나중에 수업할 예정
            #endregion

            #region 함수

            //Console.WriteLine("높이 입력하세요.");
            //int d1 = 0;
            //int.TryParse(Console.ReadLine(), out d1);

            //Console.WriteLine("너비 입력하세요.");
            //int d2 = 0;
            //int.TryParse(Console.ReadLine(), out d2);

            ////변수의 승격 (int랑 double을 연산을 같이 진행하면 더 범위가 큰 것으로 변환됨.)
            //double area = (double)d1 * d2 / 2;

            //Console.WriteLine($"면적은 {area}");

            //bool isLunchTime = false;
            //if (isLunchTime)
            //{
            //    Console.WriteLine("아닙니다.");
            //}


            //함수에는 4가지 형태가 존재함
            /*
             * 1. 아무 입력을 요구하지 않고, 결과물 반환이 없는 형태
             * 2. 입력을 요구하고, 연산 후 반환이 없는 형태의 함수
             * 3. 아무 입력을 요구하지 않고, 결과물 반환이 있는 형태의 함수
             * 4. 입력값을 요구하고, 연산 후 반환이 있는 형태의 함수
             */

            //함수에는 계산을 거쳐 나온 결과를 앞으로 '반환값' 이라고 부를 거임
            //준비물 주는걸 '인자값' 이라고 부를 거임


            //PrintMyName(Console.WriteLine());

            //TellWhatISaid(Console.ReadLine());

            //NameAndGrad(15, "이우이");

            //double output = 0;      //GetPI함수에서 받을 값 선언
            //output = GetPI();
            //Console.WriteLine(output);

            //double temp;
            //temp = CalArea(12.45, 78.52);
            //Console.WriteLine(temp);

            //double calculatedArea;
            //bool isRight = isBiggerThan100(10, 20, out calculatedArea);
            //Console.WriteLine(calculatedArea);

            //정수값 a와 b를 건네주면 서로 뒤바뀌는 mySwap이라는 기능을 만들어보겠습니다.
            //int A = 7;
            //int B = 1;
            //Console.WriteLine($"{A}, {B}");

            ////MySwap(A, B);
            //SwapNumByRef(ref A, ref B);

            ////어째서 아래의 출력의 값이 다시 돌아오는 것일까?
            //Console.WriteLine($"{A}, {B}");


            //int myNum = 0;
            //ref int number = ref myNum;
            //number++;
            //Console.WriteLine(myNum);
            //Console.WriteLine(number);

            //배열은 밖의 함수에 참조형이 변하는 것이라서 값이 변함. ref를 사용 안해도 된다는 뜻
            int[] myArr = new int[] { 1, 2, 3, 4 }; 
            ArrTest(myArr);
            Console.WriteLine(myArr[2]);
            #endregion
        }

        //[반환값] [함수 이름] [(인자값 = 매개변수)]
        //{
        //
        //}
        static void PrintMyName()
        {
            Console.WriteLine("이원형");
            Console.WriteLine("안녕");
            Console.WriteLine("대박 뭐적지");
        }

        //기능 만들고 싶은데, 결과는 딱히 없고, 준비물은 있었으면 좋겠고 그러면 함수 사용
        static void TellWhatISaid(string inputString)
        {
            Console.WriteLine("당신은 이런 말을 했습니다 " + inputString);
        }

        //준비물로 정수 점수, 문자열 이름을 받아오면, 묶어서 출력하는 기능
        static void NameAndGrad(int grade, string name)
        {
            Console.WriteLine($"{name}의 점수는 {grade} 입니다.");
        }

        //PI를 반환하는 함수 제작. 준비물은 딱히 필요 없음.
        static double GetPI()
        {
            double pi = 3.141595;
            Console.WriteLine("파이값을 반환하였습니다.");
            return pi;       //변수 pi의 값을 Main 함수에서 사용 가능
        }

        static double CalArea(double height, double width)
        {
            double area;                    //지역 변수, 로컬 변수
            area = height * width / 2;
            return area;
        }

        //두 실수를 받고, 면적을 구해보고 100보다 크면 참을 반환
        // area도 결과로 받고 싶어.
        // out
        static bool isBiggerThan100(double height, double width, out double myArea)
        {
            double area;
            area = height * width / 2;

            bool isBigger = area > 100;

            myArea = area;

            return isBigger;
        }

        //F10은 함수 생략, F11은 일일이 모든 함수 확인
        static int MySwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"{a}, {b}");

            return temp;
        }

        //ref를 사용한 변수 값 main함수
        static void SwapNumByRef(ref int a ,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"{a}, {b}");
        }

        //값타입과 참조 타입
        static void ArrTest(int[] inputArray)   //배열을 인자값으로 넘기는 방법
        {
            inputArray[2] = 111;
            Console.WriteLine($"{inputArray[2]}");
        }

    }
}
