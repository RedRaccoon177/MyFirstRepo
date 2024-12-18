using System;
using System.Collections.Generic;

namespace Day20_Project_Study_2
{
    #region 삼황 연산자 예시
    //class Weapon { }
    //class mCharacter0
    //{
    //    public string Name { get; set; }
    //    public Weapon Wpn;
    //    public int? level {  get; set; }
    //    public mCharacter(string userInput) 
    //    { 
    //        Name = (userInput == "") ? "미기입" : userInput;
    //        Wpn = (Wpn == null) ? new Weapon() : Wpn;
    //        level = (level == null) ? 1 : level;
    //        //앞에꺼 조건을 보고 맞으면 앞에껄 대입, false면 뒤에 내용 대입
    //    }
    //}
    #endregion

    #region ?의 예시 클래스
    //class mWeapon1
    //{
    //    public string Name = "Spear";
    //}

    //class mCharacter1
    //{
    //    public mWeapon wpn;
    //    public string Name { get; set; }
    //}
    #endregion

    class mWeapon
    {
        public string Name = null;
    }

    class mCharacter
    {
        public mWeapon wpn;
        public string Name { get; set; }
        public mCharacter()
        {
            wpn = new mWeapon();
        }

        public mCharacter(string wpnName)   //생성자 오버로딩 진행
        {
            wpn = new mWeapon { Name = wpnName};
        }
    }

    class Program
    {
        static void Main()
        {
            #region nullable, 널이 가능한
            //int? a = null;  //널도 담을 수 있는 널러블 인트가 되었음
            //bool? b = null; //선언을 할 때 ? 붙여서 선언
            ////여전히 값타입이긴 함. 그냥 null을 기억 가능할 뿐

            //if (a.HasValue) //HasValue를 통해 값이 있는지 없는지 판단 가능
            //{
            //    Console.WriteLine("값은" + a.Value + "입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("값이 없습니다.");
            //}
            #endregion

            #region 삼항 연산자
            //int toExamine = 10;
            //bool isBiggerThanFive;

            //if(toExamine > 5)
            //{
            //    isBiggerThanFive = true;
            //}
            //else
            //{
            //    isBiggerThanFive= false;
            //}

            //isBiggerThanFive = (toExamine > 5) ? true : false;
            #endregion

            #region ?
            //mCharacter myChar = new mCharacter { Name = "이름" }; //이니셜라이저 사용, 프로퍼티 굳
            //Console.WriteLine(myChar?.wpn?.Name); //점 옆에 ?하면 안터짐
            #endregion

            #region ??연산자
            // ?? 기준 좌측에 있는 형식이 만약 null이라면 ?? 의 우측에 있는 내용,
            // null이 아니었다면 ?? 기준 좌측에 있는 기능을 그대로 사용

            List<mCharacter> myTroop = new List<mCharacter>();

            myTroop.Add(new mCharacter());
            myTroop.Add(new mCharacter("니달리"));
            myTroop.Add(new mCharacter());
            myTroop.Add(new mCharacter("칼"));

            foreach(var myUnit in myTroop)
            {   //                                    ▼앞에꺼가 널이면 이게 사용됨
                Console.WriteLine(myUnit.wpn.Name ?? "무기가 없습니다");
                //                ▲이게 널 아니면 이거 사용  
            }
            #endregion

        }
    }
}
