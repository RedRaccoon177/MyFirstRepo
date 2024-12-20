using System;
using System.Threading;

namespace Day23_Project_Study_6
{
    class Button 
    {
        //이벤트는 외부에서 직접 시행(인보크) 할 수 없으며, 이벤트를 정의한 클래스 내부에서만 호출 가능
        //반면 이벤트 안붙인 델리게이트는 외부에서도 invoke 시킬 수 있음
        //다시 말해, 좀 더 안전한 델리게이트가 이벤트 델리게이트
        
        public event Action Onclick;

        public void Click()
        {
            Onclick += ButtonGreyOut;
            Console.WriteLine("버튼 클릭됨");
            Onclick?.Invoke();
        }

        public void ButtonGreyOut()
        {
            Console.WriteLine("버튼 회색처리됨");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a;  //얜 정수만 담음
            Action<string> b;  //얜 그냥 반환/인자 없는 함수를 담음

            //가장 대표적으로 인자, 반환도 필요없는
            b = null;
            b += Console.WriteLine;
            
            b.Invoke("이것들");
            */

            //이벤트: 델리게이트이긴 한데, 제약이 좀 더 걸린 델리게이트

            Button button = new Button();
            
            //람다식으로 이벤트 구독(등록)
            button.Onclick += () => Console.WriteLine("플레이어 점프");

            button.Click();

            //▼ 이벤트로 인해서 막힘
            button.Onclick.Invoke(); //인보크가 노출되는건 위험함

        }
    }
}
