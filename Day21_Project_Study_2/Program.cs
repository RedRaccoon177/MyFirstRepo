using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Day21_Project_Study_2
{
    class Algorithm
    {
        public static Random random = new Random();

        //셔플 알고리즘
        public static void FisherYatesShuffle(int[] intArr)
        {
            for (int i = intArr.Length - 1; i > 0; i--) //인덱스 역순
            {
                int j = random.Next(0, i + 1);
            
                int temp = intArr[i];   //i번째꺼 임시로 temp에 담아주고
                intArr[i] = intArr[j];  //j꺼를 i에 넣고
                intArr[j] = temp;   //temp를 j에 넣으면 스왑 완성
            }
        }

        //버블 정렬
        public static void BubbleSort(int[] array)
        { 
            //1. 배열을 쭉 반복하면서 인접한 두 값을 비교한다
            //2. 두 값이 크기 순서에 맞지 않으면 위치를 교환(swap)한다
            //3. 배열 끝까지 비교를 마치고, 위 과정을 반복한다.

            for (int i = 0; i<array.Length - 1; i++)    //일단 0부터 시작
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        //선택 정렬 (버블보단 좀 더 빠르다. 하지만 그래도 느리다.)
        //매 단계마다 배열에서 가장 작은거 찾아서 배열 맨 앞에 가져다 두는 식으로 작동
        //비교 횟수는 많은데...그래도 버블보단 좀 낫습니다.
        public static void SelectionSort(int[] array)
        { 
            for (int i =0; i<array.Length -1; i++)
            {
                int minIndx = i;

                for (int j = i + 1; j < array.Length; j++) //최소보다 작으면
                {
                    if (array[j] < array[minIndx])
                    {
                        minIndx = j; //인덱스 스왑
                    }
                }

                // 최소값을 현재 위치고 교환
                int temp = array[i];
                array[i] = array[minIndx];
                array[minIndx] = temp;
            }    
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //셔플 알고리즘 Fisher Yates, 피셔 예이츠
            //맨 뒤에서부터 역순으로, 앞에 인덱스 랜덤으로 뽑아다가 섞는 알고리즘

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (var a in numbers)
            {
                Console.Write( a + " ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");

            Algorithm.FisherYatesShuffle(numbers);

            foreach (var a in numbers)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Stopwatch watch = new Stopwatch();  //시간 잴 때 사용

            int[] ints = new int[100000];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Algorithm.random.Next();
            }

            watch.Start();
        
            Algorithm.SelectionSort(ints);

            Console.WriteLine(watch.ElapsedMilliseconds);

            watch.Stop();

            

        }
    }
}
