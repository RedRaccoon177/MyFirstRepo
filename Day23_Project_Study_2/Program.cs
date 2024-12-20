using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_Project_Study_2
{
    //▼ 이번엔 반환형은 인트, 인자값도 정수형 2개
    delegate int MyDel(int a, int b); 

    class TempClass
    {
        public int PrintTemp(int toAdd, int toAdd2)
        {
            return toAdd + toAdd2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Delegate 체인: 하나가 아닌 여러 함수를 담아서 쓸 수 있음

            TempClass tempClass = new TempClass();  //그냥 객체 만든것

            //▼뉴할당해서 델리게이트 형을 만들되, 매개변수로 메서드 넣어주기
            MyDel myMethod;

            myMethod = tempClass.PrintTemp;
            myMethod += tempClass.PrintTemp;
            int answer = myMethod(4, 12);

            Console.WriteLine(answer);
        }
    }
}

