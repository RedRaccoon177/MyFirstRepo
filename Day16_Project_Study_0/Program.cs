using System;

namespace Day16_Project_Study_0
{
    //partial class (파셜 클래스)
    partial class Army
    {
        Ship[] _ships = new Ship[10];

        //메서드 선언으로 private 보이게 하기
        //외부에서 넘겨온 인덱스에 외부에서 넘겨준 쉽으로 세팅
        public void SetShipByIndext(int index, Ship ship)
        {
            _ships[index] = ship;
        }
    }
    //partial  파샬클래스 => 파티얼이라고 안함
    //Army 클래스를 추가로 만듬


    //SHIP을 만들거임.
    //클래스는 항상 요소와 기능으로 이루어져있다.
    class Ship
    {
        //필드
        int _health;
        string _name;

        //메서드
        public void SetHealth(int health)
        {
            _health = health;
        }

        //생성자 (똑같은 생성자를 쓰되 인자값이 다르면 추가적으로 사용 가능 => 오버로딩)
        public Ship(string name = "타이타닉")
        {
            _name = name;
        }
        public Ship()
        {
            _name = "아무것도 없었다.";
        }
        public Ship(int health)
        {
            _health = health;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ship myShip2 = new Ship(2);

            Army myTroop = new Army();
            myTroop.SetShipByIndext(0, new Ship(15));
        }
    }
}
