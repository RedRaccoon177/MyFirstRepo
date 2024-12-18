using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;


namespace Day17_Project_Study_1
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

        public void BaseAttack()
        {

        }
    }

    class Mage: Character
    {
        string _staffType = "기본 스태프";
    }
    class Hunter : Character
    {
        string _staffType = "기본 총";
    }

    //오버라이드: 상속관계에서 부모클래스의 메서드를 자식클래스에서 재정의 해서 사용
    //혹은 덮어씌우고 본인만의 기능을 생로 만드는 것을 보고 오버라이딩이라고 부름

    class Car
    {
        protected float _maxSpeed;
        protected string _brand;

        public virtual void Drive() //virtual 가상
        {
            Console.WriteLine("주행");
        }
    }
    class Sedan : Car
    {
        public void Drive()
        {
            Console.WriteLine("승용차 주행");
        }

        public void SedanAction()
        {
            Console.WriteLine("동승자 태우기");
        }
    }
    class Truck : Car
    {
        //필드 하이딩
        new float _maxSpeed;

        //필요에 따라 파생클래스에서 재정의 하는 것을 보고, override한다고 표현
        //오버로딩은 함수 이름이 같은데 매개변수가 다르면 추가로 사용 가능한 것
        public sealed override void Drive()
        {
            Console.WriteLine("오프로드 주행");
        }
        public void TruckAction()
        {
            Console.WriteLine("짐싣기");
        }
    }
    class TwoDonBan : Truck
    {
        //하이딩
        //new는 함수를 완전 새로 만들어서 사용함
        public void Drive()
        {
            //Console.WriteLine("서스펜션 없는 날것의 주행");


        }
    }
    class Bulldoser : Car
    {
        public void Drive()
        {
            Console.WriteLine("저속 주행");
        }
        public void BulldoserAction()
        {
            Console.WriteLine("평탄화작업");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 다형성
            ////다형성
            ////객체지향 프로그래밍에서 필요에 따라 형태를 바꿀 수 있는 것을 보고 다형성이라고 함
            //// '다양하게 형을 바꾼다'

            ///*
            //Sedan sedan = new Sedan(); //sedan은 무슨형? 세단형
            //Car car; //car는 카형
            //car = sedan;
            //▼ */
            //Car car = new Sedan();  //세단형 객체를 만들고, Car형에 담은 모습임
            //Car bull = new Bulldoser();
            //Car truck = new Truck();
            ////필요에 따라 형을 바꾸었음

            //Car[] garage = new Car[3]; //Car형 여러개를 담을 배열
            //garage[0] = car; //카형으로 둔갑한 세단
            //garage[1] = bull; //카형으로 둔갑한 불도저
            //garage[2] = truck; //카형으로 둔갑한 트럭
            #endregion

            #region 오버라이드
            //오버라이드
            //Car bull = new Bulldoser();
            //Car truck = new Truck();

            //Car tdb = new TwoDonBan();
            //tdb.Drive();

            //bull.Drive();
            //truck.Drive();
            #endregion

            //추상클래스 (abstract class)
            //세부적인 구현은 자식에서 구현하도록 위임하고, 본인은
            //최소한의 기능만을 가지는 클래스
            Hunter hunter = new Hunter();
            Mage mage = new Mage();

        }
    }
}
