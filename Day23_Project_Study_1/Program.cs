using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_Project_Study_1
{
    //이러면 반환값이 int인 설계도임.
    delegate int MyintDel();

    delegate void MyDel();  //MyDel이란 이름의 델리게이트 설계도 만듦
    //델리게이트 선언 시, 반환과 인자값 형태를 이렇게 미리 적어둠
    //위 설계도의 의미는 반환X, 인자X
    //반환형이 없고, 인자가 없는 함수들을 기억할 수 있는 형식인 거임

    class TempClass
    {
        public void PrintTemp()
        {
            Console.WriteLine("도와줘");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Delegate 델리게이트
            //메서드 혹은 함수를 담을 수 있는 자료형, Delegate
            //객체의 메서드

            TempClass tempClass = new TempClass();  //그냥 객체 만든것

            //MyDel myMethod = null; //참조형, 즉 주소를 담는 자료형
            //▼뉴할당해서 델리게이트 형을 만들되, 매개변수로 메서드 넣어주기
            MyDel myMethod0 = new MyDel(tempClass.PrintTemp);  //인자X, 반환X인 애들만 기억 가능
            
            //▼이게 요즘 방식임
            MyDel myMethod1 = tempClass.PrintTemp;
            myMethod1();

            //Delegate와 정적 메소드 / 비정적 메소드
            //실체화 되어있는 주소가 필요하다. static이 대표 예시
            myMethod1 = StaticMethod;

            //static 함수가 아니라서 사용 불가
            myMethod1 = nonStaticMethod;
        }

        static void StaticMethod()
        {
            Console.WriteLine("정적 함수");
        }
        
        void nonStaticMethod()
        {
            Console.WriteLine("비정적 함수");
        }
    }
}
