using System;
using System.Threading;

namespace Day23_Project_Study_5
{
    class Program
    {
        public delegate void OnClickDe2();  //델리게이트 형식 설계도
        public OnClickDe2 onClickDel;   //그걸로 만든 onClick

        public Action OnClick;  //Action으로 한번에! //반환값 없고, 인자값 없는 델리게이트
        public Action<int> OnClick2;    //Action으로 한번에! //반환값 없고, 인자값이 인자값 하나인 델리게이트
        //------------------------------------------------------------------------
        public delegate int CalculatorDel(int x, int y);
        public CalculatorDel calculatorDel;

        public Func<int, int, int> CalculatorFunc;  //앞에 2개는 인자 타입, 뒤에 마지막 하나는 리턴 타입


        static void Main(string[] args)
        {
            //Action. C# 표준 라이브러리에 포함된 일반적인 델리게이트
        }
    }
}
