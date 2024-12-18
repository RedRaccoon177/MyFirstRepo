using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;


namespace Day17_Project_Study_0
{                 
    //어제 배운것들은 아래와 같다.
    //Static 필드
    //Static 프로퍼티
    //Static 함수
    //Static 클래스
    //상속
    //상속의 생성자

    class Beagle
    {
        //▼ Static 필드
        //- 사용하기 편리하다
        //- 클래스 모든 인스턴스가 공유한다, 클래스 자체에 속한다
        //인스턴스가 없이도 존재하는가? 사용 가능하다.

        static int _createCount;    //비글 생성 갯수
        string _name;   //비글 이름

        //▼ Static 프로퍼티 (랜덤은 저거 그대로 출력하면 터짐. 그래서 프로퍼티 만들거임.)
        static Random random;
        public static Random RandomInstance
        {
            get 
            {
                if (random == null)
                {
                    random = new Random();
                }
                return random; 
            }
        }
    }

    class Character
    {
        protected string _name;

        public Character(string name, int noMeaning)
        {
            _name = name;
        }
        public Character(string name) 
        {
            _name = name;
        }
        public Character()
        {
            _name = "default";
        }

        public void Move()
        {
            Console.WriteLine($"{_name} 이동합니다");
        }
        public void Attack()
        {
            Console.WriteLine($"캐릭터가 {_name} 공격합니다.");
        }
    }
    class Player : Character
    {
        public Player(string name) : base(name) 
        {

        }

        public void Attack()
        {
            // ▼ 부모가 private면 사용 불가
            base.Attack();
            Console.WriteLine($"플레이어가 {_name} 공격합니다.");
        }
    }
    class Enemy : Character
    {
        public void Taunt()
        {
            Console.WriteLine($"{_name} 도발합니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Beagle rookie = new Beagle();

            // ▼ Static 프로퍼티
            Console.WriteLine(Beagle.RandomInstance.Next());
            Console.WriteLine(Beagle.RandomInstance.Next());
            Console.WriteLine(Beagle.RandomInstance.Next());

            //▼ Static 함수
            // - 인스턴스 없이 실행 가능한 함수
            // - Static 함수에서 호출 가능한 함수는 Static함수뿐이다.
            // - 주로 유틸리티 함수같은거에 씀
            Math.Abs(-4566);

            //▼ Static 클래스
            //Console , Math 등 Static 클래스이다. 우리는 이미 많이 사용하고 있었다.

            Player player = new Player("홍길동");
            player.Attack();
            player.Move();

        }
    }
}
