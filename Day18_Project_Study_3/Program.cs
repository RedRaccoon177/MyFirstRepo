using System;


namespace Day18_Project_Study_3
{
    //객체지향의 원칙 SOLID
    //객체지향 4대 요소

    //오전 시간 요약
    //규율을 강제하는 interface라는 것이 있음
    //이 인터페이스는 한 클래스에도 여러개 적용 가능
    //공통된 기능을 추려내서 인터페이스로 만들면 편함
    //다형성을 활용하여 필요 시 인터페이스 형으로 바꿀 수도 있음


    //인터페이스 : 일종의 약속, 강제로 제약을 만들어 냄
    //구현 약속 모음집
    /*interface Iinteractable
    {
        
    } */

    //abstract(추상): 하나만 상속 시킬 수있다. 필드를 가질 수 있다.
    //virtual(가상)을 사용하여 기능을 완성 시킬 수도 있다.
    /*abstract class Car
    {
        int x;
        public abstract void Run0();
        public virtual void Run1()
        {
            Console.WriteLine("아무것도 재정 안했으면 자동 이거 실행");
        }
    }*/

    //인터페이스: 여러개를 한 클래스에 적용 시킬 수 있다. 필드 못가짐.
    //함수를 적용 받는 대상에서 무조건 거기서 구현해야함.
    interface IDrivable 
    {
        void Drive();
    }

    interface ITakeOff
    {
        void TakeOff();
    }

    class Plane : IDrivable
    {
        float _x;
        float _y;

        public void Drive()
        {
            Console.WriteLine("활주로로 이동");
        }

        public void Fly()
        {
            Console.WriteLine("비행기 타고 가요");
        }
    } 

    class Vehicle : IDrivable
    {
        int _x;
        int _y;

        public void Drive()
        {
            
        }

        public void LoadPeople()
        {
            Console.WriteLine("길거리서 승객 태우기");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Vehicle vehicle = new Vehicle();

            //필요할 경우 적용된 인터페이스 형으로 바꿀 수도 있음
            IDrivable[] Autobots = new IDrivable[2]; //10개의 공간만 생성

            Autobots[0] = plane;
            Autobots[1] = vehicle;

            //인터페이스를 적용받은 애들은, 인터페이스에 정의된 함수를 구현했을거란 보장이 있음.
            foreach(var robots in Autobots)
            {
                robots.Drive();
            }

        }
    }
}
