using System;
using System.Collections.Generic;
using System.Collections;

namespace Day19_Project_Study_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary : 사전 (무언가를 찾으면 그거에 대한 정보를 줌)
            //특정 키워드를 주면, 그에 해당하는 정보를 가져다 주는 자료구조
            //키값을 주면 값을 반환해줌

            //key와 value로 쓸 자료형을 요구함
            //▼ 앞에껀 키값으로 쓸 자료형, 뒤에껀 실제 저장할 값의 자료형
            Dictionary<int, string> item = new Dictionary<int, string>();
            //키에 활용될 수 있는 자료형은 보통은 int, string

            item.Add(1, "헤비머신건");
            item.Add(15, "샷건");
            item.Add(3, "에너미체이서");
            
            Console.WriteLine(item[15]);

            if (item.ContainsKey(2) == false)
            {
                item.Add(2, "신호탄");   
            }
            Console.WriteLine(item[2]);

            //Add, 꺼내쓰는 법, ConstrainsKey 정도? 
        }
    }
}
