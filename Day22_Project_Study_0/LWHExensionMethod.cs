using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Project_Study_0
{
    static class LWHExensionMethod      //확장 메서드 만들고 기능 필요할 때 막 추가하면 됨.
    {
        //스태틱 클래스는
        //스태틱, const, 스태틱 메서드만 쓸 수 있음

        //기능 추가하고자 하는 클래스 명을 this와 함께 기입
        public static void PrintReverse(this string str)
        {
            char[] charArray = str.ToCharArray(); //string을 쪼개서 배열에 담아주는 것
            Array.Reverse(charArray);   //그 배열을 거꾸로 해버림
            Console.WriteLine( new string (charArray)); //거꾸로 된 string배열을 출력.
        }



    }
}
