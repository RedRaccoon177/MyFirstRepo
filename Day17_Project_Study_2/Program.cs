using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;


namespace Day17_Project_Study_2
{
    abstract class Character //불완전한 클래스가 되었음
    {
        protected string _name;
        protected decimal _shilling;   //정확한 숫자 필요할 때 decimal
        protected uint _storyProgress; //uint는 양수만 담을때 쓰는 인트

        public void ShowMoney()
        {
            Console.WriteLine($"잔액 {_shilling}");
        }

        public abstract void BaseAttack();  //여기선 추상함수
    }

    //virtual, override, abstract 이 3가지 중요

    class Mage : Character
    {
        string _staffType = "기본 스태프";

        public override void BaseAttack()
        {
            Console.WriteLine(_staffType + " 마법 공격");
        }

        public void Teleport()
        {
            Console.WriteLine("순간이동");
        }
    }
    class Hunter : Character
    {
        string _gunType = "기본 총";

        public override void BaseAttack()
        {
            Console.WriteLine(_gunType + " 총알 공격");
        }

        public void Roll()
        {
            Console.WriteLine("구른다");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            #region
            //추상클래스 (abstract class)
            //세부적인 구현은 자식에서 구현하도록 위임하고, 본인은
            //최소한의 기능만을 가지는 클래스
            //Character hunter0 = new Hunter();
            //Hunter hunter = new Hunter();
            //Mage mage = new Mage();

            //mage.BaseAttack();
            //hunter0.BaseAttack();

            //Character wizard = new Hunter();
            ////is 키워드: 무엇이냐?
            //if (wizard is Mage) //옆에 형으로 만들어진 애라면
            //{
            //    Console.WriteLine("메이지 입니다");            
            //}

            ////as 키워드: 무엇으로 변경
            //if (wizard is Mage) //옆에 형으로 만들어진 애라면
            //{
            //    ((Mage)wizard).Teleport();   //메이지형으로 강제 형변환
            //    (wizard as Mage).Teleport(); //as 키워드로 변환은, 시도해보고 실패하면 null
            //}

            ////? 키워드: null이 가능한 형태에 ?를 붙이면, 만약 null일 경우 뒤 모든 코드 뛰어넘음
            //(wizard as Mage)?.Teleport();

            //// ▲ ▼ 위 아래 코드 같은 의미다.
            //if (wizard as Mage != null) 
            //{
            //    (wizard as Mage).Teleport(); 
            //}
            #endregion



        }
    }
}
