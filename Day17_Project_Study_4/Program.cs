using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Project_Study_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myVar = 2324;           //담겨있는 거 보고 추론한다. 알아서 지가 변환해준다는 의미임.
            var asdfsda = "sdfsd";
            var sdf = 23.24;

            //오전시간: virtual, override, abstract이 세가지만 확실히
            //오후시간: 제네릭이 좋다


            //object형으로 다양한 형을 다루면 성능 저하를 유발할 수 있고 위험하다
            //수많은 다양한 형을 다루기 위해서는 좀 더 안전한 제네릭을 사용한다
            //제네릭은 들어오는 타입에 제약도 걸 수 있고, 안전성도 보장된다

            //면접에 잘나옴
            //박싱과 언박싱
            //박싱 => 포장하다, 박스에 집어 넣는다
            //언박싱 => 박스를 열다

            int myInt = 23; //값타입
            Random rd = new Random();
            float myFloat = 23.121f;

            //힙공간에 데이터를 기억할 수 있는 공간이 생김, 거기에 우항을 복사해서 기억
            //값타입을 포장해서 힙 공간으로 보내버리는 걸 보고 박싱
            //박싱은 절차가 많아서 렉걸림.
            object myObj;
            object obInt = myInt;
            object obRd = rd;
            object obFloat = myFloat;

            Console.WriteLine((float)obFloat);
            //렉도 걸리는데 위험함
            //박싱된걸 꺼내 쓸때는 형변환을 해주어야 함. 형변환 렉 유발함. 잘못 바꾸면 위험함
            //박싱된거 꺼내 보는걸 언박싱


        }
    }
}
