using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Day19_Project_Study_2
{
    class Program
    {
        //List<>
        static void Main(string[] args)
        {
            //가변 배열. 자유롭게 항목을 넣고 지우고 이런 기능들이 내장되어 있음
            //아까 우리가 수동으로 만들었던 그런게 사실 내장되어 있음

            /*
            List<int> myFirstList = new List<int>();
            myFirstList.Add(2);
            myFirstList.Add(4);
            myFirstList.Add(8);
            myFirstList.Add(16);
            myFirstList.Add(32);

            //for (int i = 0; i < myFirstList.Count; i++)
            //{
            //    Console.WriteLine(myFirstList[i]);   
            //}
            foreach (var i in myFirstList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------");

            myFirstList.RemoveAt(2);
            for (int i = 0; i < myFirstList.Count; i++)
            {
                Console.WriteLine(myFirstList[i]);
            }
            */


            //여러개의 리스트
            List<int> invenRowFirst = new List<int>();

            /*
            List<int> invenRowSecond = new List<int>();
            List<int> invenRowThird = new List<int>();

            invenRowFirst[1] = 2;

            //자료형[] 배열명 = new 자료형[배열갯수]
            List<int>[] invenRows = new List<int>[3];
            //위의 3개로 고정시키고 싶지 않아서 이것도 가변화 시킨것이 아래것
            List<List<int>> twoDim = new List<List<int>>();

            twoDim.Add(invenRowFirst);
            twoDim.Add(invenRowSecond);
            twoDim.Add(invenRowThird);

            twoDim[0].Add(1);
            //↕위 아래 동일한 코드임
            //invenRowFirst.Add(1); 

            twoDim[0].Add(1);   //2차원 배열은 천천히 그림 그려가보면서 익히는 걸 추천드림.
            twoDim[0][0] = 1;

            //Add, RemoveAt, Count
            */

            invenRowFirst.Add(1);
            invenRowFirst.Add(4);
            invenRowFirst.Add(7);

            for (int i = 0; i < 3; i++)
            {
                //null이라서 그런것.
                if (invenRowFirst[i] == 7)
                {
                    invenRowFirst.Remove(7);
                    i--;
                }
                Console.WriteLine(invenRowFirst[i]);
            }
        }
    }
}
