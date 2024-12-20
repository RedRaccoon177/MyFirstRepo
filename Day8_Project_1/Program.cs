using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project_1
{
    #region 과제1. 다수의 인자값 요구 함수 구현
    internal class Program
    {
        static void Main(string[] args)
        {
            //4개의 정수를 인자로 받아 가장 큰 수를 출력하는 함수 제작
            int[] input = new int[4];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            GetInt(input);
        }

        static void GetInt(int[] inputArray)
        {
            int temp = 0;                         //가장 큰 수 

            for (int i = 0; i < inputArray.Length; i++)  //가장 큰 수 찾기
            {
                if (i != 3)                    //배열을 안넘기게 막기
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        temp = inputArray[i];
                    }
                    else if (inputArray[i] < inputArray[i + 1])
                    {
                        temp = inputArray[i + 1];
                    }
                }
            }
            Console.WriteLine(temp);
        }
    }
    #endregion

    #region 과제2. 다수의 인자값 및 반환형을 가진 함수 구현
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        float[] inputA = new float[5];
    //        Random random = new Random();
    //        Console.WriteLine("5개의 실수를 입력하시오.");

    //        for (int i = 0; i < inputA.Length; i++)
    //        {
    //            inputA[i] = float.Parse(Console.ReadLine());  //5개의 값을 입력하시오.
    //        }

    //        PlusTwoFloat(inputA);
    //    }

    //    static void PlusTwoFloat(float[] floatA)
    //    {
    //        float firstNum = 0;                         //가장 큰 수
    //        float secondNum = 0;                        //두번째로 큰 수
    //        float result = 0;                           
    //        float temp = 0;                             //변수값 교체용

    //        for(int i = 0; i < floatA.Length; i++)  
    //        {
    //            for (int j = i + 1 ; j < floatA.Length + 1; j++) 
    //            {
    //                if(i != floatA.Length && j != floatA.Length)
    //                {
    //                    if (floatA[i] < floatA[j])
    //                    {
    //                        temp = floatA[i];
    //                        floatA[i] = floatA[j];
    //                        floatA[j] = temp;
    //                    }
    //                }
    //            }
    //        }

    //        firstNum = floatA[0];
    //        secondNum = floatA[1];
    //        result = firstNum + secondNum;

    //        Console.WriteLine(result);
    //    }
    //}

    #endregion

    #region 과제3. 특정 조건을 포함한 함수 제작
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int inputA;
    //        int inputB ;

    //        inputA = int.Parse(Console.ReadLine());
    //        inputB = int.Parse(Console.ReadLine());

    //        bool isRight = TrueHund(inputA, inputB);

    //        Console.WriteLine(isRight);

    //    }

    //    static bool TrueHund(int outputA, int outputB) 
    //    {
    //        bool isTrue;

    //        int result0 = outputA - outputB;

    //        int result1 = Math.Abs(result0);

    //        isTrue = result1 < 100;

    //        return isTrue;
    //    }
    //}

    #endregion

    #region 심화 과제1. 복합조건을 가진 함수 제작
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int inputA = int.Parse(Console.ReadLine());  //인자값
    //        int reslut = ThreeFive(inputA);
    //        Console.WriteLine(reslut);
    //    }

    //    static int ThreeFive(int tempA)
    //    {
    //        int allPlus = 0;

    //        for (int i = 1; i < tempA; i++)
    //        {
    //            if (i % 3 == 0 || i % 5 == 0) //i가 3혹은 5일 경우
    //            {
    //                allPlus += i;
    //            }
    //        }
    //        return allPlus;
    //    }
    //}

    #endregion

    #region 심화 과제2. 자릿수 합 디코더 제작
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int myNum = int.Parse(Console.ReadLine());
    //        int result = Decoder(myNum);
    //        Console.WriteLine(result);
    //    }

    //    static int Decoder(int inputA)
    //    {
    //        int temp0 = 0;
    //        int temp1 = 0;

    //        for (int i = 1; i < inputA; i = i * 10)
    //        {
    //            temp1 = (inputA / i) % 10;

    //            temp0 = temp1 + temp0;

    //            if (inputA == 1)
    //            {
    //                temp1 = 1;
    //            }
    //        }
    //        return temp0;
    //    }
    //}

    #endregion

    #region 심화 과제3. 피보나치 함수 제작
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int myNum = int.Parse(Console.ReadLine());
    //        int real = Pibonazi(myNum);
    //        Console.WriteLine(real);
    //    }

    //    static int Pibonazi(int inputA)
    //    {
    //        int result = 0;

    //        int[] pibonazi = new int[inputA];
    //        pibonazi[0] = 1;
    //        pibonazi[1] = 1;

    //        for (int i = 0; i < pibonazi.Length; i++)
    //        {
    //            pibonazi[i + 2] = pibonazi[i] + pibonazi[i + 1];

    //            result = pibonazi[inputA-1];
    //            if (i + 2 == inputA - 1)
    //            {
    //                break;
    //            }
    //        }
    //        return result;
    //    }
    //}
    #endregion
}